

/*
        ПланРахунків_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ПланРахунків_Triggers
{
    public static Task New(ПланРахунків_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(ПланРахунків_Object ДовідникОбєкт, ПланРахунків_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПланРахунків_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПланРахунків_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(ПланРахунків_Object ДовідникОбєкт, bool label)
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

    public static Task BeforeDelete(ПланРахунків_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
