

/*
        Статті_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class Статті_Triggers
{
    public static async ValueTask New(Статті_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Статті_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(Статті_Objest ДовідникОбєкт, Статті_Objest Основа)
    {

        ДовідникОбєкт.Назва += " - Копія";

        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(Статті_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(Статті_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(Статті_Objest ДовідникОбєкт, bool label)
    {
        //Якщо встановлюється мітка на видалення
        if (label)
        {
            //Елементи помічаються на видалення
            {
                Статті_Select select = new();
                select.QuerySelect.Where.AddRange([
                    new(Статті_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                    new(Статті_Const.DELETION_LABEL, Comparison.NOT, true)
                ]);
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }
        }
    }

    public static async ValueTask BeforeDelete(Статті_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
