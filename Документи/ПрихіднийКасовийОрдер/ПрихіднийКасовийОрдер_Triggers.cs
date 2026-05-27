
/*
    ПрихіднийКасовийОрдер_Triggers.cs
    Тригери для документу ПрихіднийКасовийОрдер
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПрихіднийКасовийОрдер_Triggers
{
    public static Task New(ПрихіднийКасовийОрдер_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.ПрихіднийКасовийОрдер_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(ПрихіднийКасовийОрдер_Objest ДокументОбєкт, ПрихіднийКасовийОрдер_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПрихіднийКасовийОрдер_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрихіднийКасовийОрдер_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПрихіднийКасовийОрдер_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрихіднийКасовийОрдер_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрихіднийКасовийОрдер_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}