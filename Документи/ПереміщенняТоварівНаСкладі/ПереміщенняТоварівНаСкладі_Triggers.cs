
/*
    ПереміщенняТоварівНаСкладі_Triggers.cs
    Тригери для документу ПереміщенняТоварівНаСкладі
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПереміщенняТоварівНаСкладі_Triggers
{
    public static async Task New(ПереміщенняТоварівНаСкладі_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ПереміщенняТоварівНаСкладі();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПереміщенняТоварівНаСкладі(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(ПереміщенняТоварівНаСкладі_Object ДокументОбєкт, ПереміщенняТоварівНаСкладі_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереміщенняТоварівНаСкладі_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереміщенняТоварівНаСкладі_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереміщенняТоварівНаСкладі_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереміщенняТоварівНаСкладі_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереміщенняТоварівНаСкладі_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
