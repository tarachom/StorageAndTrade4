

/*
        ПланРахунків_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ПланРахунків_Triggers
{
    public static async ValueTask New(ПланРахунків_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(ПланРахунків_Objest ДовідникОбєкт, ПланРахунків_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(ПланРахунків_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(ПланРахунків_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(ПланРахунків_Objest ДовідникОбєкт, bool label)
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

    public static async ValueTask BeforeDelete(ПланРахунків_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    