
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
    public static async ValueTask New(Контрагенти_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Контрагенти_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(Контрагенти_Objest ДовідникОбєкт, Контрагенти_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(Контрагенти_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(Контрагенти_Objest ДовідникОбєкт)
    {
        await ФункціїДляДовідників.СтворитиДоговориКонтрагента(ДовідникОбєкт.GetDirectoryPointer());
    }

    public static async ValueTask SetDeletionLabel(Контрагенти_Objest ДовідникОбєкт, bool label)
    {
        // Помітка на виделення всіх договорів
        if (label)
        {
            ДоговориКонтрагентів_Select select = new();
            select.QuerySelect.Where.AddRange([
                new(ДоговориКонтрагентів_Const.Контрагент, Comparison.EQ, ДовідникОбєкт.UnigueID.UGuid),
                new(ДоговориКонтрагентів_Const.DELETION_LABEL, Comparison.NOT, true)
            ]);
            await select.Select();
            while (select.MoveNext())
                if (select.Current != null)
                    await select.Current.SetDeletionLabel();
        }
    }

    public static async ValueTask BeforeDelete(Контрагенти_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
