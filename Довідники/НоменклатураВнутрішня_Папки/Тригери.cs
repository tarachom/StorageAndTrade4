

/*
        НоменклатураВнутрішня_Папки_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class НоменклатураВнутрішня_Папки_Triggers
{
    public static async Task New(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.НоменклатураВнутрішня_Папки();
        ДовідникОбєкт.Код = (await НумераціяДовідників.НоменклатураВнутрішня_Папки(++number)).ToString("D6");
    }

    public static Task Copying(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт, НоменклатураВнутрішня_Папки_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт, bool label)
    {
        //Якщо встановлюється мітка на видалення
        if (label)
        {
            //Елементи помічаються на видалення
            {
                НоменклатураВнутрішня_Select select = new();
                select.QuerySelect.Where.AddRange([
                    new(НоменклатураВнутрішня_Const.Папка, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                    new(НоменклатураВнутрішня_Const.DELETION_LABEL, Comparison.NOT, true)
                ]);
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }

            //Вкладені папки помічаються на видалення
            {
                НоменклатураВнутрішня_Папки_Select select = new();
                select.QuerySelect.Where.Add(new(НоменклатураВнутрішня_Папки_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
                await select.Select();
                while (select.MoveNext())
                    if (select.Current != null)
                        await select.Current.SetDeletionLabel();
            }
        }
    }

    public static async Task BeforeDelete(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт)
    {
        //Елементи переносяться на верхній рівень
        {
            НоменклатураВнутрішня_Select select = new();
            select.QuerySelect.Where.Add(new(НоменклатураВнутрішня_Const.Папка, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
            await select.Select();

            while (select.MoveNext())
                if (select.Current != null)
                {
                    НоменклатураВнутрішня_Objest? Обєкт = await select.Current.GetDirectoryObject();
                    if (Обєкт != null)
                    {
                        //Ставиться помітка на видалення для елементу
                        await Обєкт.SetDeletionLabel();

                        Обєкт.Папка = new НоменклатураВнутрішня_Папки_Pointer();
                        await Обєкт.Save();
                    }
                }
        }

        //Вкладені папки видяляються. Для кожної папки буде викликана функція BeforeDelete
        {
            НоменклатураВнутрішня_Папки_Select select = new();
            select.QuerySelect.Where.Add(new(НоменклатураВнутрішня_Папки_Const.Родич, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid));
            await select.Select();

            while (select.MoveNext())
                if (select.Current != null)
                {
                    НоменклатураВнутрішня_Папки_Objest? Обєкт = await select.Current.GetDirectoryObject();
                    if (Обєкт != null)
                        await Обєкт.Delete();
                }
        }
    }
}
