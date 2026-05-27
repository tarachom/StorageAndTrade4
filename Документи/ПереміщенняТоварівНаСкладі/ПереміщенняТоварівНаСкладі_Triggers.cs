
/*
    ПереміщенняТоварівНаСкладі_Triggers.cs
    Тригери для документу ПереміщенняТоварівНаСкладі
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПереміщенняТоварівНаСкладі_Triggers
{
    public static Task New(ПереміщенняТоварівНаСкладі_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.ПереміщенняТоварівНаСкладі_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(ПереміщенняТоварівНаСкладі_Objest ДокументОбєкт, ПереміщенняТоварівНаСкладі_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереміщенняТоварівНаСкладі_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереміщенняТоварівНаСкладі_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереміщенняТоварівНаСкладі_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереміщенняТоварівНаСкладі_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереміщенняТоварівНаСкладі_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
