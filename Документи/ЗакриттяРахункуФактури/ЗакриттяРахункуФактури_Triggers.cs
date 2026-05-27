
/*
    ЗакриттяРахункуФактури_Triggers.cs
    Тригери для документу ЗакриттяРахункуФактури
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ЗакриттяРахункуФактури_Triggers
{
    public static Task New(ЗакриттяРахункуФактури_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.ЗакриттяРахункуФактури_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;
        return Task.CompletedTask;
    }

    public static Task Copying(ЗакриттяРахункуФактури_Objest ДокументОбєкт, ЗакриттяРахункуФактури_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗакриттяРахункуФактури_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗакриттяРахункуФактури_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗакриттяРахункуФактури_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗакриттяРахункуФактури_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗакриттяРахункуФактури_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
