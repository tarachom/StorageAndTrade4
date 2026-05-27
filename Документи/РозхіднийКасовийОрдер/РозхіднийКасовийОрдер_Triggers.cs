
/*
    РозхіднийКасовийОрдер_Triggers.cs
    Тригери для документу РозхіднийКасовийОрдер
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class РозхіднийКасовийОрдер_Triggers
{
    public static Task New(РозхіднийКасовийОрдер_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.РозхіднийКасовийОрдер_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(РозхіднийКасовийОрдер_Objest ДокументОбєкт, РозхіднийКасовийОрдер_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РозхіднийКасовийОрдер_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РозхіднийКасовийОрдер_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РозхіднийКасовийОрдер_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РозхіднийКасовийОрдер_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РозхіднийКасовийОрдер_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
