
/*
    РахунокФактура_Triggers.cs
    Тригери для документу РахунокФактура
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class РахунокФактура_Triggers
{
    public static Task New(РахунокФактура_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.РахунокФактура_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(РахунокФактура_Objest ДокументОбєкт, РахунокФактура_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РахунокФактура_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РахунокФактура_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РахунокФактура_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РахунокФактура_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РахунокФактура_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
