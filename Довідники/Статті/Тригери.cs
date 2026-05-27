

/*
        Статті_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class Статті_Triggers
{
    public static Task New(Статті_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Статті_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(Статті_Objest ДовідникОбєкт, Статті_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Статті_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Статті_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(Статті_Objest ДовідникОбєкт, bool label)
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

    public static Task BeforeDelete(Статті_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
