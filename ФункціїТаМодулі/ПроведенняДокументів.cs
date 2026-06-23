
/*

    Модуль проведення документів

*/

using AccountingSoftware;
using GeneratedCode;
using GeneratedCode.Константи;
using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;
using GeneratedCode.РегістриНакопичення;

class ПроведенняДокументів
{
    /// <summary>
    /// Список наявних партій на дату документу не враховуючи сам документ
    /// </summary>
    /// <param name="Організація">Організація</param>
    /// <param name="Номенклатура">Номенклатура</param>
    /// <param name="ХарактеристикаНоменклатури">ХарактеристикаНоменклатури</param>
    /// <param name="Серія">Серія</param>
    /// <param name="Склад">Склад</param>
    /// <param name="Owner">UID Документу який проводиться</param>
    /// <param name="OwnerDateDoc">Дата документу який проводиться</param>
    /// <param name="Кількість">Кількість яку потрібно списати</param>
    /// <returns>Іменований список</returns>
    public static async Task<SelectRequest_Record> ОтриматиСписокНаявнихПартій(
        Організації_Pointer Організація,
        Номенклатура_Pointer Номенклатура,
        ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури,
        СеріїНоменклатури_Pointer Серія,
        Склади_Pointer Склад,
        ПартіяТоварівКомпозит_Pointer Партія,
        UniqueID Owner,
        DateTime OwnerDateDoc,
        decimal Кількість)
    {
        МетодиСписання МетодСписанняЗКонстанти = await ПартіїТоварів.МетодСписанняПартій();
        МетодиСписання МетодСписання;

        if (МетодСписанняЗКонстанти == МетодиСписання.FIFO)
            МетодСписання = МетодиСписання.FIFO;
        else if (МетодСписанняЗКонстанти == МетодиСписання.LIFO)
            МетодСписання = МетодиСписання.LIFO;
        else
            МетодСписання = МетодиСписання.FIFO;

        string МетодСортування = МетодСписання == МетодиСписання.FIFO ? "ASC" : "DESC";

        //
        //Вибірка партій з регістру з відборами по параметрах
        //

        string query = $@"
WITH register AS
(
	SELECT 
		ПартіїТоварів.{ПартіїТоварів_Const.ПартіяТоварівКомпозит} AS ПартіяТоварівКомпозит,
		ПартіїТоварів.{ПартіїТоварів_Const.Рядок} AS Рядок,
		SUM(CASE WHEN ПартіїТоварів.income = true THEN 
			ПартіїТоварів.{ПартіїТоварів_Const.Кількість} ELSE 
			-ПартіїТоварів.{ПартіїТоварів_Const.Кількість} END) AS Кількість,
		SUM(CASE WHEN ПартіїТоварів.income = true THEN 
			ПартіїТоварів.{ПартіїТоварів_Const.Собівартість} ELSE 
			-ПартіїТоварів.{ПартіїТоварів_Const.Собівартість} END) AS Собівартість
	FROM
		{ПартіїТоварів_Const.TABLE} AS ПартіїТоварів
	WHERE
		ПартіїТоварів.period <= @period_end
		AND ПартіїТоварів.{ПартіїТоварів_Const.Організація} = '{Організація.UniqueID}'
		AND ПартіїТоварів.{ПартіїТоварів_Const.Номенклатура} = '{Номенклатура.UniqueID}'
		AND ПартіїТоварів.{ПартіїТоварів_Const.ХарактеристикаНоменклатури} = '{ХарактеристикаНоменклатури.UniqueID}'
		AND ПартіїТоварів.{ПартіїТоварів_Const.Серія} = '{Серія.UniqueID}'
        AND ПартіїТоварів.{ПартіїТоварів_Const.Склад} = '{Склад.UniqueID}'";

        if (!Партія.IsEmpty())
        {
            query += $@"
        AND ПартіїТоварів.{ПартіїТоварів_Const.ПартіяТоварівКомпозит} = '{Партія.UniqueID}'";
        }

        query += $@"
        AND ПартіїТоварів.owner != '{Owner}'

	GROUP BY ПартіяТоварівКомпозит, Рядок

	HAVING
		SUM(CASE WHEN ПартіїТоварів.income = true THEN 
			ПартіїТоварів.{ПартіїТоварів_Const.Кількість} ELSE 
			-ПартіїТоварів.{ПартіїТоварів_Const.Кількість} END) > 0
)";

        //
        //ДостатняКількість обчислюється для того щоб вибирати тільки потрібні партії, а не всі наявні партії.
        //ДостатняКількість = Накопичена кількість >= Потрібній кількості
        //

        query += $@"
, Обчислення AS
(
	SELECT
	   Довідник_ПартіяТоварівКомпозит.{ПартіяТоварівКомпозит_Const.Дата} AS ДатаПоступлення,
	   register.ПартіяТоварівКомпозит,
       register.Рядок,
	   register.Кількість,
	   register.Собівартість,
	   SUM(register.Кількість) OVER(ORDER BY Довідник_ПартіяТоварівКомпозит.{ПартіяТоварівКомпозит_Const.Дата} {МетодСортування}, register.Рядок) >= @Кількість AS ДостатняКількість
	FROM
	   register
            LEFT JOIN {ПартіяТоварівКомпозит_Const.TABLE} AS Довідник_ПартіяТоварівКомпозит ON Довідник_ПартіяТоварівКомпозит.uid = 
                register.ПартіяТоварівКомпозит
	ORDER BY ДатаПоступлення {МетодСортування}
)";

        //
        //Вибираються дві групи
        //1. Партії які мають кількість меншу потрібній кількості
        //2. Одну партію яка закриває потрібну кількість
        //

        query += $@"
(
	SELECT 
		ПартіяТоварівКомпозит,
        Рядок,
		Кількість,
		Собівартість
	FROM Обчислення
	WHERE ДостатняКількість = false
)
UNION ALL
(
	SELECT 
		ПартіяТоварівКомпозит,
        Рядок,
		Кількість,
		Собівартість
	FROM Обчислення
	WHERE ДостатняКількість = true
	LIMIT 1
)
";
        return await Config.Kernel.DataBase.SelectRequest(query, new()
        {
            { "period_end", OwnerDateDoc },
            { "Кількість", Кількість }
        });
    }

    /// <summary>
    /// Залишки товару на складі на дату документу не враховуючи сам документ
    /// </summary>
    /// <param name="Номенклатура">Номенклатура</param>
    /// <param name="ХарактеристикаНоменклатури">ХарактеристикаНоменклатури</param>
    /// <param name="Серія">Серія</param>
    /// <param name="Склад">Склад</param>
    /// <param name="Owner">UID Документу який проводиться</param>
    /// <param name="OwnerDateDoc">Дата документу який проводиться</param>
    /// <returns>Іменований список</returns>
    public static async Task<SelectRequest_Record> ОтриматиЗалишкиТоваруНаСкладі(
        Номенклатура_Pointer Номенклатура, ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури,
        СеріїНоменклатури_Pointer Серія, Склади_Pointer Склад,
        UniqueID Owner, DateTime OwnerDateDoc)
    {
        string query = $@"
WITH register AS
(
	SELECT 
		'Залишок' AS Група,
		SUM(CASE WHEN ТовариНаСкладах.income = true THEN 
			ТовариНаСкладах.{ТовариНаСкладах_Const.ВНаявності} ELSE 
			-ТовариНаСкладах.{ТовариНаСкладах_Const.ВНаявності} END) AS ВНаявності
	FROM
		{ТовариНаСкладах_Const.TABLE} AS ТовариНаСкладах
	WHERE
		ТовариНаСкладах.period <= @period_end
		AND ТовариНаСкладах.{ТовариНаСкладах_Const.Номенклатура} = '{Номенклатура.UniqueID}'
		AND ТовариНаСкладах.{ТовариНаСкладах_Const.ХарактеристикаНоменклатури} = '{ХарактеристикаНоменклатури.UniqueID}'
        AND ТовариНаСкладах.{ТовариНаСкладах_Const.Серія} = '{Серія.UniqueID}'
        AND ТовариНаСкладах.{ТовариНаСкладах_Const.Склад} = '{Склад.UniqueID}'
        AND ТовариНаСкладах.owner != '{Owner}'

	GROUP BY Група
)
SELECT
    ВНаявності
FROM
    register
";
        return await Config.Kernel.DataBase.SelectRequest(query, new()
        {
            { "period_end", OwnerDateDoc }
        });
    }

    /// <summary>
    /// Залишки товару в комірці на дату документу не враховуючи сам документ
    /// </summary>
    /// <param name="Номенклатура">Номенклатура</param>
    /// <param name="ХарактеристикаНоменклатури">ХарактеристикаНоменклатури</param>
    /// <param name="Пакування">Пакування</param>
    /// <param name="Комірка">Комірка</param>
    /// <param name="Серія">Серія</param>
    /// <param name="Owner">UID Документу який проводиться</param>
    /// <param name="OwnerDateDoc">Дата документу який проводиться</param>
    /// <returns>Іменований список</returns>
    public static async Task<SelectRequest_Record> ОтриматиЗалишкиТоваруВКомірці(
        Номенклатура_Pointer Номенклатура, ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури,
        ПакуванняОдиниціВиміру_Pointer Пакування, СкладськіКомірки_Pointer Комірка,
        СеріїНоменклатури_Pointer Серія,
        UniqueID Owner, DateTime OwnerDateDoc)
    {
        string query = $@"
WITH register AS
(
	SELECT 
		'Залишок' AS Група,
		SUM(CASE WHEN ТовариВКомірках.income = true THEN 
			ТовариВКомірках.{ТовариВКомірках_Const.ВНаявності} ELSE 
			-ТовариВКомірках.{ТовариВКомірках_Const.ВНаявності} END) AS ВНаявності
	FROM
		{ТовариВКомірках_Const.TABLE} AS ТовариВКомірках
	WHERE
		ТовариВКомірках.period <= @period_end
		AND ТовариВКомірках.{ТовариВКомірках_Const.Номенклатура} = '{Номенклатура.UniqueID}'
		AND ТовариВКомірках.{ТовариВКомірках_Const.ХарактеристикаНоменклатури} = '{ХарактеристикаНоменклатури.UniqueID}'
        AND ТовариВКомірках.{ТовариВКомірках_Const.Пакування} = '{Пакування.UniqueID}'
        AND ТовариВКомірках.{ТовариВКомірках_Const.Комірка} = '{Комірка.UniqueID}'
        AND ТовариВКомірках.{ТовариВКомірках_Const.Серія} = '{Серія.UniqueID}'
        AND ТовариВКомірках.owner != '{Owner}'

	GROUP BY Група
)
SELECT
    ВНаявності
FROM
    register
";
        return await Config.Kernel.DataBase.SelectRequest(query, new()
        {
            { "period_end", OwnerDateDoc }
        });
    }

    /// <summary>
    /// Зарезервовані та наявні товари на складі на дату документу не враховуючи сам документ
    /// </summary>
    /// <param name="Номенклатура">Номенклатура</param>
    /// <param name="ХарактеристикаНоменклатури">ХарактеристикаНоменклатури</param>
    /// <param name="Склад">Склад</param>
    /// <param name="Owner">UID Документу який проводиться</param>
    /// <param name="OwnerDateDoc">Дата документу який проводиться</param>
    /// <returns>Іменований список</returns>
    public static async Task<SelectRequest_Record> ОтриматиРезервТоваруНаСкладі(
        Номенклатура_Pointer Номенклатура, ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури, Склади_Pointer Склад,
        UniqueID Owner, DateTime OwnerDateDoc)
    {
        string query = $@"
WITH register AS
(
	SELECT 
		'Резерв' AS Група,
        SUM(CASE WHEN ВільніЗалишки.income = true THEN 
			ВільніЗалишки.{ВільніЗалишки_Const.ВНаявності} ELSE 
			-ВільніЗалишки.{ВільніЗалишки_Const.ВНаявності} END) AS ВНаявності,
		SUM(CASE WHEN ВільніЗалишки.income = true THEN 
			ВільніЗалишки.{ВільніЗалишки_Const.ВРезервіЗіСкладу} ELSE 
			-ВільніЗалишки.{ВільніЗалишки_Const.ВРезервіЗіСкладу} END) AS ВРезервіЗіСкладу,
        SUM(CASE WHEN ВільніЗалишки.income = true THEN 
			ВільніЗалишки.{ВільніЗалишки_Const.ВРезервіПідЗамовлення} ELSE 
			-ВільніЗалишки.{ВільніЗалишки_Const.ВРезервіПідЗамовлення} END) AS ВРезервіПідЗамовлення
	FROM
		{ВільніЗалишки_Const.TABLE} AS ВільніЗалишки
	WHERE
		ВільніЗалишки.period <= @period_end
		AND ВільніЗалишки.{ВільніЗалишки_Const.Номенклатура} = '{Номенклатура.UniqueID}'
		AND ВільніЗалишки.{ВільніЗалишки_Const.ХарактеристикаНоменклатури} = '{ХарактеристикаНоменклатури.UniqueID}'
        AND ВільніЗалишки.{ВільніЗалишки_Const.Склад} = '{Склад.UniqueID}'
        AND ВільніЗалишки.owner != '{Owner}'
	GROUP BY Група
)
SELECT
    ВНаявності,
    ВРезервіЗіСкладу,
    ВРезервіПідЗамовлення
FROM
    register
";

        return await Config.Kernel.DataBase.SelectRequest(query, new()
        {
            { "period_end", OwnerDateDoc }
        });
    }

    /// <summary>
    /// Ортримати кількість зарезервованого товару конкретним документом
    /// </summary>
    /// <param name="Номенклатура">Номенклатура</param>
    /// <param name="ХарактеристикаНоменклатури">ХарактеристикаНоменклатури</param>
    /// <param name="Склад">Склад</param>
    /// <param name="Owner">Документ</param>
    /// <returns>Іменований список</returns>
    public static async Task<SelectRequest_Record> ОтриматиРезервТоваруПоДокументу(
        Номенклатура_Pointer Номенклатура, ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури, Склади_Pointer Склад,
        UniqueID ДокументРезерву, UniqueID Owner, DateTime OwnerDateDoc)
    {
        string query = $@"
WITH register AS
(
	SELECT 
		'Резерв' AS Група,
		SUM(CASE WHEN ВільніЗалишки.income = true THEN 
			ВільніЗалишки.{ВільніЗалишки_Const.ВРезервіЗіСкладу} ELSE 
			-ВільніЗалишки.{ВільніЗалишки_Const.ВРезервіЗіСкладу} END) AS ВРезервіЗіСкладу
	FROM
		{ВільніЗалишки_Const.TABLE} AS ВільніЗалишки
	WHERE
        ВільніЗалишки.period <= @period_end
        AND ВільніЗалишки.{ВільніЗалишки_Const.ДокументРезерву} = '{ДокументРезерву}'
		AND ВільніЗалишки.{ВільніЗалишки_Const.Номенклатура} = '{Номенклатура.UniqueID}'
		AND ВільніЗалишки.{ВільніЗалишки_Const.ХарактеристикаНоменклатури} = '{ХарактеристикаНоменклатури.UniqueID}'
        AND ВільніЗалишки.{ВільніЗалишки_Const.Склад} = '{Склад.UniqueID}'
        AND ВільніЗалишки.owner != '{Owner}'
	GROUP BY Група
)
SELECT
    ВРезервіЗіСкладу
FROM
    register
";
        return await Config.Kernel.DataBase.SelectRequest(query, new()
        {
            { "period_end", OwnerDateDoc }
        });
    }

    /// <summary>
    /// Замовлення клієнта для товару по документу
    /// </summary>
    /// <param name="Номенклатура">Номенклатура</param>
    /// <param name="ХарактеристикаНоменклатури">ХарактеристикаНоменклатури</param>
    /// <param name="Склад">Склад</param>
    /// <param name="ЗамовленняКлієнта">ЗамовленняКлієнта</param>
    /// <param name="Owner">Документ</param>
    /// <param name="OwnerDateDoc">Дата документу</param>
    /// <returns></returns>
    public static async Task<SelectRequest_Record> ОтриматиЗамовленняКлієнтаДляТоваруПоДокументу(
        Номенклатура_Pointer Номенклатура, ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури, Склади_Pointer Склад,
        UniqueID ЗамовленняКлієнта, UniqueID Owner, DateTime OwnerDateDoc)
    {
        string query = $@"
WITH register AS
(
	SELECT 
		'Замовлення' AS Група,
		SUM(CASE WHEN ЗамовленняКлієнтів.income = true THEN 
			ЗамовленняКлієнтів.{ЗамовленняКлієнтів_Const.Замовлено} ELSE 
			-ЗамовленняКлієнтів.{ЗамовленняКлієнтів_Const.Замовлено} END) AS Замовлено,

        SUM(CASE WHEN ЗамовленняКлієнтів.income = true THEN 
			ЗамовленняКлієнтів.{ЗамовленняКлієнтів_Const.Сума} ELSE 
			-ЗамовленняКлієнтів.{ЗамовленняКлієнтів_Const.Сума} END) AS Сума
	FROM
		{ЗамовленняКлієнтів_Const.TABLE} AS ЗамовленняКлієнтів
	WHERE
        ЗамовленняКлієнтів.period <= @period_end
        AND ЗамовленняКлієнтів.{ЗамовленняКлієнтів_Const.ЗамовленняКлієнта} = '{ЗамовленняКлієнта}'
		AND ЗамовленняКлієнтів.{ЗамовленняКлієнтів_Const.Номенклатура} = '{Номенклатура.UniqueID}'
		AND ЗамовленняКлієнтів.{ЗамовленняКлієнтів_Const.ХарактеристикаНоменклатури} = '{ХарактеристикаНоменклатури.UniqueID}'
        AND ЗамовленняКлієнтів.{ЗамовленняКлієнтів_Const.Склад} = '{Склад.UniqueID}'
        AND ЗамовленняКлієнтів.owner != '{Owner}'
	GROUP BY Група
)
SELECT
    Замовлено,
    Сума
FROM
    register
";
        return await Config.Kernel.DataBase.SelectRequest(query, new()
        {
            { "period_end", OwnerDateDoc }
        });
    }

    /// <summary>
    /// Замовлення постачальника для товару по документу
    /// </summary>
    /// <param name="Номенклатура">Номенклатура</param>
    /// <param name="ХарактеристикаНоменклатури">ХарактеристикаНоменклатури</param>
    /// <param name="Склад">Склад</param>
    /// <param name="ЗамовленняПостачальнику">ЗамовленняПостачальнику</param>
    /// <param name="Owner">Документ</param>
    /// <param name="OwnerDateDoc">Дата документу</param>
    /// <returns></returns>
    public static async Task<SelectRequest_Record> ОтриматиЗамовленняПостачальникуДляТоваруПоДокументу(
        Номенклатура_Pointer Номенклатура, ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури, Склади_Pointer Склад,
        UniqueID ЗамовленняПостачальнику, UniqueID Owner, DateTime OwnerDateDoc)
    {
        string query = $@"
WITH register AS
(
	SELECT 
		'Замовлення' AS Група,
		SUM(CASE WHEN ЗамовленняПостачальникам.income = true THEN 
			ЗамовленняПостачальникам.{ЗамовленняПостачальникам_Const.Замовлено} ELSE 
			-ЗамовленняПостачальникам.{ЗамовленняПостачальникам_Const.Замовлено} END) AS Замовлено
	FROM
		{ЗамовленняПостачальникам_Const.TABLE} AS ЗамовленняПостачальникам
	WHERE
        ЗамовленняПостачальникам.period <= @period_end
        AND ЗамовленняПостачальникам.{ЗамовленняПостачальникам_Const.ЗамовленняПостачальнику} = '{ЗамовленняПостачальнику}'
		AND ЗамовленняПостачальникам.{ЗамовленняПостачальникам_Const.Номенклатура} = '{Номенклатура.UniqueID}'
		AND ЗамовленняПостачальникам.{ЗамовленняПостачальникам_Const.ХарактеристикаНоменклатури} = '{ХарактеристикаНоменклатури.UniqueID}'
        AND ЗамовленняПостачальникам.{ЗамовленняПостачальникам_Const.Склад} = '{Склад.UniqueID}'
        AND ЗамовленняПостачальникам.owner != '{Owner}'
	GROUP BY Група
)
SELECT
    Замовлено
FROM
    register
";
        return await Config.Kernel.DataBase.SelectRequest(query, new()
        {
            { "period_end", OwnerDateDoc }
        });
    }

    /// <summary>
    /// Додати інформаційне повідомлення в процесі проведення документу
    /// </summary>
    /// <param name="ДокументОбєкт">Документ обєкт</param>
    /// <param name="НазваДокументу">Назва документу</param>
    /// <param name="Інформація">Повідомлення</param>
    public static async void ДодатиІнформаційнеПовідомлення(DocumentObject ДокументОбєкт, string НазваДокументу, string Інформація)
    {
        await Config.Kernel.MessageInfoAdd("Проведення документу", ДокументОбєкт.UniqueID.UGuid, $"Документи.{ДокументОбєкт.TypeDocument}", НазваДокументу, Інформація);
    }

    /// <summary>
    /// Перервати проведення документу
    /// </summary>
    /// <param name="ДокументОбєкт">Документ обєкт</param>
    /// <param name="НазваДокументу">Назва документу</param>
    /// <param name="СписокПомилок">Список помилок</param>
    public static async Task ДокументНеПроводиться(DocumentObject ДокументОбєкт, string НазваДокументу, string СписокПомилок) =>
         await Config.Kernel.MessageErrorAdd("Проведення документу", ДокументОбєкт.UniqueID.UGuid, $"Документи.{ДокументОбєкт.TypeDocument}", НазваДокументу,
            СписокПомилок + "\n\nДокумент [ " + НазваДокументу + " ] не проводиться!");
}
