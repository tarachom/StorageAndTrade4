

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
    public static async ValueTask New(БухгалтерськаОперація_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.БухгалтерськаОперація_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(БухгалтерськаОперація_Objest ДокументОбєкт, БухгалтерськаОперація_Objest Основа)
    {
        
        ДокументОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(БухгалтерськаОперація_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{БухгалтерськаОперація_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(БухгалтерськаОперація_Objest ДокументОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(БухгалтерськаОперація_Objest ДокументОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(БухгалтерськаОперація_Objest ДокументОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    