

/*
        БухгалтерськаОперація_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;
using StorageAndTrade;

namespace GeneratedCode.Документи;

static class БухгалтерськаОперація_Triggers
{
    public static Task New(БухгалтерськаОперація_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.БухгалтерськаОперація_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        return Task.CompletedTask;
    }

    public static Task Copying(БухгалтерськаОперація_Objest ДокументОбєкт, БухгалтерськаОперація_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(БухгалтерськаОперація_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{БухгалтерськаОперація_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(БухгалтерськаОперація_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(БухгалтерськаОперація_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(БухгалтерськаОперація_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
