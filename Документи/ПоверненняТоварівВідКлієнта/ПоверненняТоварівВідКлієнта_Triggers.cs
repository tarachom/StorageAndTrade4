
/*
    ПоверненняТоварівВідКлієнта_Triggers.cs
    Тригери для документу ПоверненняТоварівВідКлієнта
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПоверненняТоварівВідКлієнта_Triggers
{
    public static async Task New(ПоверненняТоварівВідКлієнта_Objest ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ПоверненняТоварівВідКлієнта();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПоверненняТоварівВідКлієнта(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;
    }

    public static Task Copying(ПоверненняТоварівВідКлієнта_Objest ДокументОбєкт, ПоверненняТоварівВідКлієнта_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПоверненняТоварівВідКлієнта_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПоверненняТоварівВідКлієнта_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПоверненняТоварівВідКлієнта_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПоверненняТоварівВідКлієнта_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПоверненняТоварівВідКлієнта_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
