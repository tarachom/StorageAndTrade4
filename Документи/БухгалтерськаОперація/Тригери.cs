

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
    public static async Task New(БухгалтерськаОперація_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.БухгалтерськаОперація();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.БухгалтерськаОперація(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(БухгалтерськаОперація_Object ДокументОбєкт, БухгалтерськаОперація_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(БухгалтерськаОперація_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{БухгалтерськаОперація_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(БухгалтерськаОперація_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(БухгалтерськаОперація_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(БухгалтерськаОперація_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
