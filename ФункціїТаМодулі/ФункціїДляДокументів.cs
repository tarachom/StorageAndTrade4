/*

Функції для документів

*/

using AccountingSoftware;
using GeneratedCode;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

using КурсиВалют = GeneratedCode.РегістриВідомостей.КурсиВалют_Const;

namespace StorageAndTrade;

/// <summary>
/// Спільні функції для документів
/// </summary>
static class ФункціїДляДокументів
{
    /// <summary>
    /// Функція обєднує дві дати (з першої дата, з другої час)
    /// </summary>
    /// <param name="дата">Дата</param>
    /// <param name="час">Час</param>
    /// <returns>Обєднана дата</returns>
    public static DateTime ОбєднатиДатуТаЧас(DateTime дата, DateTime час) => new(дата.Year, дата.Month, дата.Day, час.Hour, час.Minute, час.Second);

    #region Бухгалтерія

    /// <summary>
    /// Функція формує значення для реквізитів Аналітика які залежать від реквізиту Рахунок
    /// </summary>
    /// <param name="Аналітика">Значення реквізиту аналітика</param>
    /// <param name="Субконто">Тип даних</param>
    public static UuidAndText ЗадатиТипАналітики(UuidAndText Аналітика, string Субконто) =>
        !string.IsNullOrEmpty(Субконто) && Аналітика.Text == Субконто ?
            //Якщо тип не зімінився, залишаю також значення
            new(Аналітика.Uuid, Субконто) :
            //Тільки тип задається
            new(Субконто);

    /// <summary>
    /// Створити документ БухгалтерськаОперація або оновити існуючий
    /// </summary>
    /// <param name="ДокументБухгалтерськаОперація">Вказівник на документ БухгалтерськаОперація</param>
    /// <returns>Повертає вказівник на документ БухгалтерськаОперація</returns>
    public static async Task<БухгалтерськаОперація_Pointer> СтворитиДокументБухгалтерськаОперація(БухгалтерськаОперація_Pointer ДокументБухгалтерськаОперація, ДляНовогоДокументуБухгалтерськаОперація Реквізити)
    {
        БухгалтерськаОперація_Objest? БухОперація;
        if (ДокументБухгалтерськаОперація.IsEmpty())
        {
            БухОперація = new();
            await БухОперація.New();
        }
        else
            БухОперація = await ДокументБухгалтерськаОперація.GetDocumentObject();

        if (БухОперація != null)
        {
            БухОперація.ДатаДок = Реквізити.ДатаДок;
            БухОперація.Організація = Реквізити.Організація;
            БухОперація.Основа = Реквізити.Основа;
            await БухОперація.Save();

            return БухОперація.GetDocumentPointer();
        }
        else
            return new();
    }

    /// <summary>
    /// Парметр для функції СтворитиДокументБухгалтерськаОперація
    /// </summary>
    public record ДляНовогоДокументуБухгалтерськаОперація
    {
        public DateTime ДатаДок { get; init; } = DateTime.MinValue;
        public Організації_Pointer Організація { get; init; } = new();
        public UuidAndText Основа { get; init; } = new();
    }

    #endregion

    #region ПартіяТоварівКомпозит

    /// <summary>
    /// Функція повертає вказівник на елемент довідника ПартіяТоварівКомпозит
    /// </summary>
    /// <param name="ДокументКлюч">Ключ документу</param>
    /// <param name="ТипДокументу">Тип документу</param>
    /// <param name="ДокументПоступлення"></param>
    /// <param name="ДокументВведенняЗалишків"></param>
    /// <returns></returns>
    public static async Task<ПартіяТоварівКомпозит_Pointer> ОтриматиПартіюТоварівКомпозит(
        Guid ДокументКлюч, ТипДокументуПартіяТоварівКомпозит ТипДокументу,
        ПоступленняТоварівТаПослуг_Objest? ДокументПоступлення,
        ВведенняЗалишків_Objest? ДокументВведенняЗалишків)
    {
        ПартіяТоварівКомпозит_Pointer ПартіяТоварівКомпозит = await new ПартіяТоварівКомпозит_Select()
            .FindByField(ПартіяТоварівКомпозит_Const.ДокументКлюч, ДокументКлюч);

        ПартіяТоварівКомпозит_Objest партіяТоварівКомпозитНовий = new();
        if (ПартіяТоварівКомпозит.IsEmpty())
            await партіяТоварівКомпозитНовий.New();
        else if (!await партіяТоварівКомпозитНовий.Read(ПартіяТоварівКомпозит.UniqueID))
            await партіяТоварівКомпозитНовий.New();

        партіяТоварівКомпозитНовий.ТипДокументу = ТипДокументу;
        партіяТоварівКомпозитНовий.ДокументКлюч = ДокументКлюч;

        switch (ТипДокументу)
        {
            case ТипДокументуПартіяТоварівКомпозит.ПоступленняТоварівТаПослуг when ДокументПоступлення != null:
                {
                    партіяТоварівКомпозитНовий.Дата = ДокументПоступлення.ДатаДок;
                    партіяТоварівКомпозитНовий.Назва = ДокументПоступлення.Назва;
                    партіяТоварівКомпозитНовий.ПоступленняТоварівТаПослуг = ДокументПоступлення.GetDocumentPointer();
                    break;
                }
            case ТипДокументуПартіяТоварівКомпозит.ВведенняЗалишків when ДокументВведенняЗалишків != null:
                {
                    партіяТоварівКомпозитНовий.Дата = ДокументВведенняЗалишків.ДатаДок;
                    партіяТоварівКомпозитНовий.Назва = ДокументВведенняЗалишків.Назва;
                    партіяТоварівКомпозитНовий.ВведенняЗалишків = ДокументВведенняЗалишків.GetDocumentPointer();
                    break;
                }
        }

        await партіяТоварівКомпозитНовий.Save();
        return партіяТоварівКомпозитНовий.GetDirectoryPointer();
    }

    #endregion

    /// <summary>
    /// Функція повертає перший із списку договорів - договір контрагента
    /// </summary>
    /// <param name="Контрагент">Контрагент</param>
    /// <param name="ТипДоговору">Тип договору</param>
    /// <returns></returns>
    public static async Task<ДоговориКонтрагентів_Pointer?> ОсновнийДоговірДляКонтрагента(Контрагенти_Pointer Контрагент, ТипДоговорів ТипДоговору = 0)
    {
        if (Контрагент.IsEmpty())
            return null;

        ДоговориКонтрагентів_Select договориКонтрагентів = new();

        //Відбір по контрагенту
        договориКонтрагентів.QuerySelect.Where.Add(new(ДоговориКонтрагентів_Const.Контрагент, Comparison.EQ, Контрагент.UniqueID.UGuid));

        //Відбір по типу договору
        if (ТипДоговору != 0)
            договориКонтрагентів.QuerySelect.Where.Add(new(ДоговориКонтрагентів_Const.ТипДоговору, Comparison.EQ, (int)ТипДоговору));

        return await договориКонтрагентів.SelectSingle() ? договориКонтрагентів.Current : null;
    }

    /// <summary>
    /// Функція повертає курс валюти на дату
    /// </summary>
    /// <param name="Валюта">Валюта</param>
    /// <param name="ДатаКурсу">Курс</param>
    /// <returns>Курс на дату (дата + час 23 59 59) або 0</returns>
    public static async Task<decimal> ПоточнийКурсВалюти(Валюти_Pointer Валюта, DateTime ДатаКурсу)
    {
        if (Валюта.IsEmpty())
            return 0;

        string query = @$"
SELECT
    КурсиВалют.{КурсиВалют.Курс} AS Курс
FROM
    {КурсиВалют.TABLE} AS КурсиВалют
WHERE
    КурсиВалют.{КурсиВалют.Валюта} = @valuta AND
    КурсиВалют.period <= @date_curs
ORDER BY КурсиВалют.period DESC
LIMIT 1
";
        Dictionary<string, object> paramQuery = new()
        {
            { "valuta", Валюта.UniqueID.UGuid },
            { "date_curs", new DateTime(ДатаКурсу.Year, ДатаКурсу.Month, ДатаКурсу.Day, 23, 59, 59) }
        };

        var recordResult = await Config.Kernel.DataBase.SelectRequest(query, paramQuery);
        if (recordResult.Result)
        {
            Dictionary<string, object> Рядок = recordResult.ListRow[0];
            return (decimal)Рядок["Курс"];
        }
        else
            return 0;
    }
}