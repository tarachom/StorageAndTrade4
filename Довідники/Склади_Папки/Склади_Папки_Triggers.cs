
/*
    Склади_Папки_Triggers.cs
    Тригери для довідника Склади_Папки
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

class Склади_Папки_Triggers
{
    public static async Task New(Склади_Папки_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Склади_Папки();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Склади_Папки(++number)).ToString("D6");
    }

    public static Task Copying(Склади_Папки_Object ДовідникОбєкт, Склади_Папки_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Склади_Папки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Склади_Папки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(Склади_Папки_Object ДовідникОбєкт, bool label)
    {
        //Якщо встановлюється мітка на видалення
        if (label)
        {
            //Елементи помічаються на видалення
            {
                Склади_Select select = new();
                select.QuerySelect.Where.AddRange([
                    new(Склади_Const.Папка, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                    new(Склади_Const.DELETION_LABEL, Comparison.NOT, true)
                ]);
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }

            //Вкладені папки помічаються на видалення
            {
                Склади_Папки_Select select = new();
                select.QuerySelect.Where.Add(new(Склади_Папки_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }
        }
    }

    public static async Task BeforeDelete(Склади_Папки_Object ДовідникОбєкт)
    {
        //Елементи переносяться на верхній рівень
        {
            Склади_Select select = new();
            select.QuerySelect.Where.Add(new(Склади_Const.Папка, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
            await select.Select();

            while (select.MoveNext())
                if (select.Current != null)
                {
                    Склади_Object? Обєкт = await select.Current.GetDirectoryObject();

                    if (Обєкт != null)
                    {
                        //Ставиться помітка на видалення для елементу
                        await Обєкт.SetDeletionLabel();

                        Обєкт.Папка = new Склади_Папки_Pointer();
                        await Обєкт.Save();
                    }
                }
        }

        //Вкладені папки видяляються. Для кожної папки буде викликана функція BeforeDelete
        {
            Склади_Папки_Select select = new();
            select.QuerySelect.Where.Add(new(Склади_Папки_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
            await select.Select();

            while (select.MoveNext())
                if (select.Current != null)
                {
                    Склади_Папки_Object? Обєкт = await select.Current.GetDirectoryObject();
                    if (Обєкт != null)
                        await Обєкт.Delete();
                }
        }
    }
}
