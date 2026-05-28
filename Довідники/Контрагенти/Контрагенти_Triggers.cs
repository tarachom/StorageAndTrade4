
/*
    Контрагенти_Triggers.cs
    Тригери для довідника Контрагенти
*/

using GeneratedCode.Константи;
using AccountingSoftware;
using StorageAndTrade;

namespace GeneratedCode.Довідники;

class Контрагенти_Triggers
{
    public static async Task New(Контрагенти_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Контрагенти();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Контрагенти(++number)).ToString("D6");
    }

    public static Task Copying(Контрагенти_Objest ДовідникОбєкт, Контрагенти_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Контрагенти_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task AfterSave(Контрагенти_Objest ДовідникОбєкт)
    {
        await ФункціїДляДовідників.СтворитиДоговориКонтрагента(ДовідникОбєкт.GetDirectoryPointer());
    }

    public static async Task SetDeletionLabel(Контрагенти_Objest ДовідникОбєкт, bool label)
    {
        // Помітка на виделення всіх договорів
        if (label)
        {
            ДоговориКонтрагентів_Select select = new();
            select.QuerySelect.Where.AddRange([
                new(ДоговориКонтрагентів_Const.Контрагент, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                new(ДоговориКонтрагентів_Const.DELETION_LABEL, Comparison.NOT, true)
            ]);
            await select.Select();
            while (select.MoveNext())
                if (select.Current != null)
                    await select.Current.SetDeletionLabel();
        }
    }

    public static Task BeforeDelete(Контрагенти_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
