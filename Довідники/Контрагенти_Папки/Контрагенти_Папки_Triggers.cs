
/*
    Контрагенти_Папки_Triggers.cs
    Тригери для довідника Контрагенти_Папки
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

class Контрагенти_Папки_Triggers
{
    public static async Task New(Контрагенти_Папки_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Контрагенти_Папки();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Контрагенти_Папки(++number)).ToString("D6");
    }

    public static Task Copying(Контрагенти_Папки_Objest ДовідникОбєкт, Контрагенти_Папки_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Контрагенти_Папки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Контрагенти_Папки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(Контрагенти_Папки_Objest ДовідникОбєкт, bool label)
    {
        //Якщо встановлюється мітка на видалення
        if (label)
        {
            //Елементи помічаються на видалення
            {
                Контрагенти_Select select = new();
                select.QuerySelect.Where.AddRange([
                    new(Контрагенти_Const.Папка, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                    new(Контрагенти_Const.DELETION_LABEL, Comparison.NOT, true)
                ]);
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }

            //Вкладені папки помічаються на видалення
            {
                Контрагенти_Папки_Select select = new();
                select.QuerySelect.Where.Add(new(Контрагенти_Папки_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }
        }
    }

    public static async Task BeforeDelete(Контрагенти_Папки_Objest ДовідникОбєкт)
    {
        //Елементи переносяться на верхній рівень
        {
            Контрагенти_Select select = new();
            select.QuerySelect.Where.Add(new(Контрагенти_Const.Папка, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
            await select.Select();

            while (select.MoveNext())
                if (select.Current != null)
                {
                    Контрагенти_Objest? Обєкт = await select.Current.GetDirectoryObject();
                    if (Обєкт != null)
                    {
                        //Ставиться помітка на видалення для елементу
                        await Обєкт.SetDeletionLabel();

                        //Зміна папки
                        Обєкт.Папка = new Контрагенти_Папки_Pointer();
                        await Обєкт.Save();
                    }
                }
        }

        //Вкладені папки видаляються. Для кожної папки буде викликана функція BeforeDelete
        {
            Контрагенти_Папки_Select select = new();
            select.QuerySelect.Where.Add(new(Контрагенти_Папки_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
            await select.Select();

            while (select.MoveNext())
                if (select.Current != null)
                {
                    Контрагенти_Папки_Objest? контрагенти_Папки_Objest = await select.Current.GetDirectoryObject();
                    if (контрагенти_Папки_Objest != null)
                        await контрагенти_Папки_Objest.Delete();
                }
        }
    }
}