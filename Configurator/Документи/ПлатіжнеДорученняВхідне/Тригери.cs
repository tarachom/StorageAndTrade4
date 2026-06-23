

/*
        ПлатіжнеДорученняВхідне_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПлатіжнеДорученняВхідне_Triggers
{
    public static async Task New(ПлатіжнеДорученняВхідне_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПлатіжнеДорученняВхідне();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПлатіжнеДорученняВхідне(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПлатіжнеДорученняВхідне_Object ДокументОбєкт, ПлатіжнеДорученняВхідне_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПлатіжнеДорученняВхідне_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПлатіжнеДорученняВхідне_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПлатіжнеДорученняВхідне_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПлатіжнеДорученняВхідне_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПлатіжнеДорученняВхідне_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    