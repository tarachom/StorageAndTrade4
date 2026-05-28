

/*
        ПлатіжнеДорученняВихідне_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПлатіжнеДорученняВихідне_Triggers
{
    public static async Task New(ПлатіжнеДорученняВихідне_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПлатіжнеДорученняВихідне();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПлатіжнеДорученняВихідне(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПлатіжнеДорученняВихідне_Objest ДокументОбєкт, ПлатіжнеДорученняВихідне_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПлатіжнеДорученняВихідне_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПлатіжнеДорученняВихідне_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПлатіжнеДорученняВихідне_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПлатіжнеДорученняВихідне_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПлатіжнеДорученняВихідне_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    