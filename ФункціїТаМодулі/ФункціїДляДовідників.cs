/*

Спільні функції для довідників 

*/

using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

/// <summary>
/// Спільні функції для довідників 
/// </summary>
static class ФункціїДляДовідників
{
    /// <summary>
    /// Функція створює договори для контрагента
    /// </summary>
    /// <param name="Контрагент">Контрагент</param>
    public static async ValueTask СтворитиДоговориКонтрагента(Контрагенти_Pointer контрагент)
    {
        if (контрагент.IsEmpty())
            return;

        await СтворитиДоговір(ТипДоговорів.ЗПокупцями, ГосподарськіОперації.ПоступленняОплатиВідКлієнта);
        await СтворитиДоговір(ТипДоговорів.ЗПостачальниками, ГосподарськіОперації.ОплатаПостачальнику);

        //Внутрішня функція
        async ValueTask СтворитиДоговір(ТипДоговорів типДоговору, ГосподарськіОперації операція)
        {
            ДоговориКонтрагентів_Select Вибірка = new();

            Вибірка.QuerySelect.Where.AddRange([
                new(ДоговориКонтрагентів_Const.Контрагент, Comparison.EQ, контрагент.UniqueID.UGuid), //Відбір по контрагенту
                new(ДоговориКонтрагентів_Const.ТипДоговору, Comparison.EQ, (int)типДоговору)          //Відбір по типу договору
            ]);

            if (!await Вибірка.Select())
            {
                ДоговориКонтрагентів_Objest Новий = new()
                {
                    Назва = "Основний договір",
                    Контрагент = контрагент,
                    Статус = СтатусиДоговорівКонтрагентів.Діє,
                    Дата = DateTime.Now,
                    ТипДоговору = типДоговору,
                    ГосподарськаОперація = операція
                };

                await Новий.New();
                await Новий.Save();
            }
        }
    }

    /// <summary>
    /// Функція повертає вказівник на серійний номер, або створює новий
    /// </summary>
    /// <returns>Вказівник на елемент довідника СеріїНоменклатури</returns>
    public static async ValueTask<СеріїНоменклатури_Pointer?> ОтриматиВказівникНаСеріюНоменклатури(string номер)
    {
        номер = номер.Trim();

        СеріїНоменклатури_Pointer ЗнайденаСеріяНоменклатури = await new СеріїНоменклатури_Select().FindByField(СеріїНоменклатури_Const.Номер, номер);
        if (!ЗнайденаСеріяНоменклатури.IsEmpty())
            return ЗнайденаСеріяНоменклатури;
        else
        {
            СеріїНоменклатури_Objest НоваСеріяНоменклатури = new() { Номер = номер };
            await НоваСеріяНоменклатури.New();
            await НоваСеріяНоменклатури.Save();

            return НоваСеріяНоменклатури.GetDirectoryPointer();
        }
    }

    /// <summary>
    /// Створення нового запису довідника Файли
    /// </summary>
    /// <param name="PathToFile">Шлях до файлу</param>
    /// <returns></returns>
    public static async ValueTask<Файли_Pointer> ЗавантажитиФайл(string pathToFile)
    {
        FileInfo fileInfo = new(pathToFile);

        Файли_Objest Обєкт = new()
        {
            НазваФайлу = fileInfo.Name,
            Назва = Path.GetFileNameWithoutExtension(pathToFile),
            Розмір = Math.Round((decimal)(fileInfo.Length / 1024)).ToString() + " KB",
            ДатаСтворення = DateTime.Now,
            БінарніДані = File.ReadAllBytes(pathToFile)
        };

        await Обєкт.New();
        await Обєкт.Save();

        return Обєкт.GetDirectoryPointer();
    }
}
