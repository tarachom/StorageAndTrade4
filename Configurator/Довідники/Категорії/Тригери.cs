

/*
        Категорії_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class Категорії_Triggers
{
    public static async ValueTask New(Категорії_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Категорії_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(Категорії_Objest ДовідникОбєкт, Категорії_Objest Основа)
    {

        ДовідникОбєкт.Назва += " - Копія";

        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(Категорії_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(Категорії_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(Категорії_Objest ДовідникОбєкт, bool label)
    {
        //Якщо встановлюється мітка на видалення
        if (label)
        {
            //Елементи помічаються на видалення
            {
                Категорії_Select select = new();
                select.QuerySelect.Where.AddRange([
                    new(Категорії_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                    new(Категорії_Const.DELETION_LABEL, Comparison.NOT, true)
                ]);
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }
        }
    }

    public static async ValueTask BeforeDelete(Категорії_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
