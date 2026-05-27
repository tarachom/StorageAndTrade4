
/*
    Номенклатура_Папки_Triggers.cs
    Тригери для довідника Номенклатура_Папки
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

class Номенклатура_Папки_Triggers
{
    public static  Task New(Номенклатура_Папки_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Номенклатура_Папки_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static  Task Copying(Номенклатура_Папки_Objest ДовідникОбєкт, Номенклатура_Папки_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static  Task BeforeSave(Номенклатура_Папки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static  Task AfterSave(Номенклатура_Папки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(Номенклатура_Папки_Objest ДовідникОбєкт, bool label)
    {
        //Якщо встановлюється мітка на видалення
        if (label)
        {
            //Елементи помічаються на видалення
            {
                Номенклатура_Select select = new();
                select.QuerySelect.Where.AddRange([
                    new(Номенклатура_Const.Папка, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                    new(Номенклатура_Const.DELETION_LABEL, Comparison.NOT, true)
                ]);
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }

            //Вкладені папки помічаються на видалення
            {
                Номенклатура_Папки_Select select = new();
                select.QuerySelect.Where.Add(new(Номенклатура_Папки_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }
        }
    }

    public static async Task BeforeDelete(Номенклатура_Папки_Objest ДовідникОбєкт)
    {
        //Елементи переносяться на верхній рівень
        {
            Номенклатура_Select select = new();
            select.QuerySelect.Where.Add(new(Номенклатура_Const.Папка, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
            await select.Select();

            while (select.MoveNext())
                if (select.Current != null)
                {
                    Номенклатура_Objest? Обєкт = await select.Current.GetDirectoryObject();
                    if (Обєкт != null)
                    {
                        //Ставиться помітка на видалення для елементу
                        await Обєкт.SetDeletionLabel();

                        Обєкт.Папка = new Номенклатура_Папки_Pointer();
                        await Обєкт.Save();
                    }
                }
        }

        //Вкладені папки видяляються. Для кожної папки буде викликана функція BeforeDelete
        {
            Номенклатура_Папки_Select select = new();
            select.QuerySelect.Where.Add(new(Номенклатура_Папки_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
            await select.Select();

            while (select.MoveNext())
                if (select.Current != null)
                {
                    Номенклатура_Папки_Objest? Обєкт = await select.Current.GetDirectoryObject();
                    if (Обєкт != null)
                        await Обєкт.Delete();
                }
        }
    }
}