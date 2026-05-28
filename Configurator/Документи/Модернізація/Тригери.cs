

/*
        Модернізація_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class Модернізація_Triggers
{
    public static async Task New(Модернізація_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.Модернізація();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.Модернізація(++number)).ToString("D8");
                    
    }

    public static Task Copying(Модернізація_Objest ДокументОбєкт, Модернізація_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Модернізація_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Модернізація_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(Модернізація_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Модернізація_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Модернізація_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    