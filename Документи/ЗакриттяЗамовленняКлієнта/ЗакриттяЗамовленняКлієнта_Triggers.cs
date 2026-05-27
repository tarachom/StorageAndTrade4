
/*
    ЗакриттяЗамовленняКлієнта_Triggers.cs
    Тригери для документу ЗакриттяЗамовленняКлієнта
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ЗакриттяЗамовленняКлієнта_Triggers
{
    public static Task New(ЗакриттяЗамовленняКлієнта_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.ЗакриттяЗамовленняКлієнта_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;
        return Task.CompletedTask;
    }

    public static Task Copying(ЗакриттяЗамовленняКлієнта_Objest ДокументОбєкт, ЗакриттяЗамовленняКлієнта_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗакриттяЗамовленняКлієнта_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗакриттяЗамовленняКлієнта_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗакриттяЗамовленняКлієнта_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗакриттяЗамовленняКлієнта_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗакриттяЗамовленняКлієнта_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
