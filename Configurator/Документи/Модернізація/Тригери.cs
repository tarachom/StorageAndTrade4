

/*
        Модернізація_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class Модернізація_Triggers
{
    public static async Task New(Модернізація_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.Модернізація();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.Модернізація(++number)).ToString("D8");
                    
    }

    public static Task Copying(Модернізація_Object ДокументОбєкт, Модернізація_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Модернізація_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Модернізація_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(Модернізація_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Модернізація_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Модернізація_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    