
/*
    СкладськіКомірки_Папки_Triggers.cs
    Тригери для довідника СкладськіКомірки_Папки
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

class СкладськіКомірки_Папки_Triggers
{
    public static async Task New(СкладськіКомірки_Папки_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.СкладськіКомірки_Папки();
        ДовідникОбєкт.Код = (await НумераціяДовідників.СкладськіКомірки_Папки(++number)).ToString("D6");
    }

    public static Task Copying(СкладськіКомірки_Папки_Objest ДовідникОбєкт, СкладськіКомірки_Папки_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СкладськіКомірки_Папки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(СкладськіКомірки_Папки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(СкладськіКомірки_Папки_Objest ДовідникОбєкт, bool label)
    {
        //Якщо встановлюється мітка на видалення
        if (label)
        {
            //Елементи помічаються на видалення
            {
                СкладськіКомірки_Select select = new();
                select.QuerySelect.Where.AddRange([
                    new(СкладськіКомірки_Const.Папка, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                    new(СкладськіКомірки_Const.DELETION_LABEL, Comparison.NOT, true)
                ]);
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }

            //Вкладені папки помічаються на видалення
            {
                СкладськіКомірки_Папки_Select select = new();
                select.QuerySelect.Where.Add(new(СкладськіКомірки_Папки_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }
        }
    }

    public static async Task BeforeDelete(СкладськіКомірки_Папки_Objest ДовідникОбєкт)
    {
        //Елементи помічаються на видалення
        {
            СкладськіКомірки_Select select = new();
            select.QuerySelect.Where.AddRange([
                new(СкладськіКомірки_Const.Папка, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                new(СкладськіКомірки_Const.DELETION_LABEL, Comparison.NOT, true)
            ]);
            await select.Select();
            while (select.MoveNext())
                if (select.Current != null)
                {
                    СкладськіКомірки_Objest? Обєкт = await select.Current.GetDirectoryObject();
                    if (Обєкт != null)
                    {
                        await Обєкт.SetDeletionLabel();

                        Обєкт.Папка = new СкладськіКомірки_Папки_Pointer();
                        await Обєкт.Save();
                    }
                }
        }

        //Вкладені папки помічаються на видалення
        {
            СкладськіКомірки_Папки_Select select = new();
            select.QuerySelect.Where.Add(new(СкладськіКомірки_Папки_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
            await select.Select();

            while (select.MoveNext())
                if (select.Current != null)
                {
                    СкладськіКомірки_Папки_Objest? Обєкт = await select.Current.GetDirectoryObject();
                    if (Обєкт != null)
                        await Обєкт.Delete();
                }
        }
    }
}