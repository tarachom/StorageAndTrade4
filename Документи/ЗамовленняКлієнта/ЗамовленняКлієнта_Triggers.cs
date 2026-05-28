
/*
    ЗамовленняКлієнта_Triggers.cs
    Тригери для документу ЗамовленняКлієнта
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ЗамовленняКлієнта_Triggers
{
    public static async Task New(ЗамовленняКлієнта_Objest ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ЗамовленняКлієнта();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗамовленняКлієнта(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;
    }

    public static Task Copying(ЗамовленняКлієнта_Objest ДокументОбєкт, ЗамовленняКлієнта_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗамовленняКлієнта_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗамовленняКлієнта_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗамовленняКлієнта_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗамовленняКлієнта_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗамовленняКлієнта_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
