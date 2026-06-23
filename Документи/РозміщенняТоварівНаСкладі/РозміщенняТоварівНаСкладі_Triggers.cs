
/*
    РозміщенняТоварівНаСкладі_Triggers.cs
    Тригери для документу РозміщенняТоварівНаСкладі
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class РозміщенняТоварівНаСкладі_Triggers
{
    public static async Task New(РозміщенняТоварівНаСкладі_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.РозміщенняТоварівНаСкладі();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.РозміщенняТоварівНаСкладі(++number)).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(РозміщенняТоварівНаСкладі_Object ДокументОбєкт, РозміщенняТоварівНаСкладі_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РозміщенняТоварівНаСкладі_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РозміщенняТоварівНаСкладі_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РозміщенняТоварівНаСкладі_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РозміщенняТоварівНаСкладі_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РозміщенняТоварівНаСкладі_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
