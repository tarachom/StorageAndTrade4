

/*
        ПлатіжнеДорученняВхідне_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПлатіжнеДорученняВхідне_Triggers
{
    public static async Task New(ПлатіжнеДорученняВхідне_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПлатіжнеДорученняВхідне();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПлатіжнеДорученняВхідне(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПлатіжнеДорученняВхідне_Objest ДокументОбєкт, ПлатіжнеДорученняВхідне_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПлатіжнеДорученняВхідне_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПлатіжнеДорученняВхідне_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПлатіжнеДорученняВхідне_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПлатіжнеДорученняВхідне_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПлатіжнеДорученняВхідне_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    