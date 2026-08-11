

/*
        Номенклатура_Triggers.cs
        Тригери
*/


using GeneratedCode.Константи;
using AccountingSoftware;
using StorageAndTrade;
using GeneratedCode.Перелічення;

namespace GeneratedCode.Довідники;

static class Номенклатура_Triggers
{
    public static async Task New(Номенклатура_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Номенклатура();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Номенклатура(++number)).ToString("D6");

        ДовідникОбєкт.БазоваОдиницяВиміру = await ЗначенняТипові.ОсновнаОдиницяВиміруЗаКласифікатором();
        ДовідникОбєкт.ТипНоменклатури = ТипиНоменклатури.Товар;
        ДовідникОбєкт.ВидНоменклатури = await ЗначенняТипові.ОсновнийВидНоменклатури();
    }

    public static Task Copying(Номенклатура_Object ДовідникОбєкт, Номенклатура_Object Підстава)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static async Task BeforeSave(Номенклатура_Object ДовідникОбєкт)
    {
        //Встановлення базової од. виміру для номенклатури
        if (ДовідникОбєкт.БазоваОдиницяВиміру.IsEmpty())
            ДовідникОбєкт.БазоваОдиницяВиміру = await ЗначенняТипові.ОсновнаОдиницяВиміруЗаКласифікатором();
    }

    public static async Task AfterSave(Номенклатура_Object ДовідникОбєкт)
    {
        _ = await ФункціїДляДовідників.СтворитиОсновнуОдиницюВиміру(ДовідникОбєкт);
    }

    public static async Task SetDeletionLabel(Номенклатура_Object ДовідникОбєкт, bool label)
    {
        if (label)
        {
            // Помітка на видалення всіх характеристик елементу номенклатури у випадку label = true
            // Якщо мітка знімається, то з характеристик мітка не має зніматися
            {
                ХарактеристикиНоменклатури_Select select = new();
                select.QuerySelect.Where.AddRange([
                    new(ХарактеристикиНоменклатури_Const.Номенклатура, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                    new(ХарактеристикиНоменклатури_Const.DELETION_LABEL, Comparison.NOT, true)
                ]);

                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }

            // Помітка на видалення всіх одиниць виміру
            {
                ПакуванняОдиниціВиміру_Select select = new();
                select.QuerySelect.Where.AddRange([
                    new(ПакуванняОдиниціВиміру_Const.Номенклатура, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                    new(ПакуванняОдиниціВиміру_Const.DELETION_LABEL, Comparison.NOT, true)
                ]);

                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }
        }
    }

    public static Task BeforeDelete(Номенклатура_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}