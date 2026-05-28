
/*
    ЗбіркаТоварівНаСкладі_Triggers.cs
    Тригери для документу ЗбіркаТоварівНаСкладі
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ЗбіркаТоварівНаСкладі_Triggers
{
    public static async Task New(ЗбіркаТоварівНаСкладі_Objest ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ЗбіркаТоварівНаСкладі();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗбіркаТоварівНаСкладі(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(ЗбіркаТоварівНаСкладі_Objest ДокументОбєкт, ЗбіркаТоварівНаСкладі_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗбіркаТоварівНаСкладі_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗбіркаТоварівНаСкладі_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗбіркаТоварівНаСкладі_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗбіркаТоварівНаСкладі_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗбіркаТоварівНаСкладі_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
