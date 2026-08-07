/*

Спільні функції для довідників 

*/

using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Константи;
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
    public static async Task СтворитиДоговориКонтрагента(Контрагенти_Pointer Контрагент)
    {
        if (Контрагент.IsEmpty())
            return;

        await СтворитиДоговір(ТипДоговорів.ЗПокупцями, ГосподарськіОперації.ПоступленняОплатиВідКлієнта);
        await СтворитиДоговір(ТипДоговорів.ЗПостачальниками, ГосподарськіОперації.ОплатаПостачальнику);

        //Внутрішня функція
        async Task СтворитиДоговір(ТипДоговорів типДоговору, ГосподарськіОперації операція)
        {
            ДоговориКонтрагентів_Select Вибірка = new();

            Вибірка.QuerySelect.Where.AddRange([
                new(ДоговориКонтрагентів_Const.Контрагент, Comparison.EQ, Контрагент.UniqueID.UGuid), //Відбір по контрагенту
                new(ДоговориКонтрагентів_Const.ТипДоговору, Comparison.EQ, (int)типДоговору)          //Відбір по типу договору
            ]);

            if (!await Вибірка.Select())
            {
                ДоговориКонтрагентів_Object Новий = new()
                {
                    Назва = "Основний договір",
                    Контрагент = Контрагент,
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
    /// Функція створює основну одиницю виміру
    /// </summary>
    /// <param name="НоменклатураОбєкт">Номенклатура об'єкт</param>
    /// <returns>Повертає вказівник на перший основний елемент</returns>
    public static async Task<ПакуванняОдиниціВиміру_Pointer> СтворитиОсновнуОдиницюВиміру(Номенклатура_Object НоменклатураОбєкт)
    {
        КласифікаторОдиницьВиміру_Pointer БазоваОдиницяВиміру = НоменклатураОбєкт.БазоваОдиницяВиміру.IsEmpty() ?
            НоменклатураОбєкт.БазоваОдиницяВиміру : await ЗначенняТипові.ОсновнаОдиницяВиміруЗаКласифікатором();

        //
        // Пошук в одиницях виміру основної одиниці
        //

        ПакуванняОдиниціВиміру_Select Вибірка = new();
        Вибірка.QuerySelect.Where.AddRange([
            new(ПакуванняОдиниціВиміру_Const.Номенклатура, Comparison.EQ, НоменклатураОбєкт.UniqueID.UGuid), //Відбір по Номенклатура власник
            new(ПакуванняОдиниціВиміру_Const.ОдиницяЗаКласифікатором, Comparison.EQ, БазоваОдиницяВиміру.UniqueID.UGuid), // Відбір по класифікатору
            new(ПакуванняОдиниціВиміру_Const.Коєфіціент, Comparison.EQ, 1), // Коєфіціент = 1
        ]);

        //Якщо вибірка пуста
        if (!await Вибірка.SelectSingle())
        {
            await БазоваОдиницяВиміру.GetPresentation();

            //Новий запис
            ПакуванняОдиниціВиміру_Object НовийОбєкт = new()
            {
                Номенклатура = НоменклатураОбєкт.GetDirectoryPointer(),
                ОдиницяЗаКласифікатором = БазоваОдиницяВиміру,
                Коєфіціент = 1,
                Назва = БазоваОдиницяВиміру.Name,
                НазваПовна = БазоваОдиницяВиміру.Name,
            };

            await НовийОбєкт.New();
            await НовийОбєкт.Save();

            return НовийОбєкт.GetDirectoryPointer();
        }
        else if (Вибірка.Current != null)
            return Вибірка.Current;
        else
            return new();
    }

    /// <summary>
    /// Функція повертає вказівник на серійний номер, або створює новий
    /// </summary>
    /// <returns>Вказівник на елемент довідника СеріїНоменклатури</returns>
    public static async Task<СеріїНоменклатури_Pointer?> ОтриматиВказівникНаСеріюНоменклатури(string номер)
    {
        номер = номер.Trim();

        СеріїНоменклатури_Pointer ЗнайденаСеріяНоменклатури = await new СеріїНоменклатури_Select().FindByField(СеріїНоменклатури_Const.Номер, номер);
        if (!ЗнайденаСеріяНоменклатури.IsEmpty())
            return ЗнайденаСеріяНоменклатури;
        else
        {
            СеріїНоменклатури_Object НоваСеріяНоменклатури = new() { Номер = номер };
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
    public static async Task<Файли_Pointer> ЗавантажитиФайл(string pathToFile)
    {
        FileInfo fileInfo = new(pathToFile);

        Файли_Object Обєкт = new()
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
