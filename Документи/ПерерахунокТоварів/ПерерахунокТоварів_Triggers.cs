
/*
    ПерерахунокТоварів_Triggers.cs
    Тригери для документу ПерерахунокТоварів
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПерерахунокТоварів_Triggers
{
    public static async Task New(ПерерахунокТоварів_Objest ДокументОбєкт)
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

    public static Task Copying(ПерерахунокТоварів_Objest ДокументОбєкт, ПерерахунокТоварів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПерерахунокТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПерерахунокТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПерерахунокТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПерерахунокТоварів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПерерахунокТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}