
/*
    ПсуванняТоварів_Triggers.cs
    Тригери для документу ПсуванняТоварів
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПсуванняТоварів_Triggers
{
    public static Task New(ПсуванняТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.ПсуванняТоварів_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(ПсуванняТоварів_Objest ДокументОбєкт, ПсуванняТоварів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПсуванняТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПсуванняТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПсуванняТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПсуванняТоварів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПсуванняТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
