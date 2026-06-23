

/*
        Статті_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class Статті_Triggers
{
    public static async Task New(Статті_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Статті();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Статті(++number)).ToString("D6");
    }

    public static Task Copying(Статті_Object ДовідникОбєкт, Статті_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Статті_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Статті_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(Статті_Object ДовідникОбєкт, bool label)
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

    public static Task BeforeDelete(Статті_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
