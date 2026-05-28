

/*
        Категорії_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class Категорії_Triggers
{
    public static async Task New(Категорії_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Категорії();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Категорії(++number)).ToString("D6");
    }

    public static Task Copying(Категорії_Objest ДовідникОбєкт, Категорії_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Категорії_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Категорії_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(Категорії_Objest ДовідникОбєкт, bool label)
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

    public static Task BeforeDelete(Категорії_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
