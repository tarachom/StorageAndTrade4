
/*
    ПерерахунокТоварів_Triggers.cs
    Тригери для документу ПерерахунокТоварів
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПерерахунокТоварів_Triggers
{
    public static async Task New(ПерерахунокТоварів_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ПерерахунокТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПерерахунокТоварів(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;

        //Відповідального можна отримати з Користувача
        var Користувач_Обєкт = await Program.Користувач.GetDirectoryObject();
        if (Користувач_Обєкт != null)
            ДокументОбєкт.Відповідальний = Користувач_Обєкт.ФізичнаОсоба;
    }

    public static Task Copying(ПерерахунокТоварів_Object ДокументОбєкт, ПерерахунокТоварів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПерерахунокТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПерерахунокТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПерерахунокТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПерерахунокТоварів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПерерахунокТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}