

/*
        ПланРахунків_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ПланРахунків_Triggers
{
    public static Task New(ПланРахунків_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(ПланРахунків_Objest ДовідникОбєкт, ПланРахунків_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПланРахунків_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПланРахунків_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(ПланРахунків_Objest ДовідникОбєкт, bool label)
    {
        //Якщо встановлюється мітка на видалення
        if (label)
        {
            //Елементи помічаються на видалення
            {
                ПланРахунків_Select select = new();
                select.QuerySelect.Where.AddRange([
                    new(ПланРахунків_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                    new(ПланРахунків_Const.DELETION_LABEL, Comparison.NOT, true)
                ]);
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }
        }
    }

    public static Task BeforeDelete(ПланРахунків_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
