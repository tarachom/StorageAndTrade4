
/*
    ПсуванняТоварів_Triggers.cs
    Тригери для документу ПсуванняТоварів
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПсуванняТоварів_Triggers
{
    public static async Task New(ПсуванняТоварів_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ПсуванняТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПсуванняТоварів(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(ПсуванняТоварів_Object ДокументОбєкт, ПсуванняТоварів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПсуванняТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПсуванняТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПсуванняТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПсуванняТоварів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПсуванняТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
