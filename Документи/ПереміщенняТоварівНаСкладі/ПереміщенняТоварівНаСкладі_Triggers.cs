
/*
    ПереміщенняТоварівНаСкладі_Triggers.cs
    Тригери для документу ПереміщенняТоварівНаСкладі
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПереміщенняТоварівНаСкладі_Triggers
{
    public static async Task New(ПереміщенняТоварівНаСкладі_Objest ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ПереміщенняТоварівНаСкладі();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПереміщенняТоварівНаСкладі(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
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
