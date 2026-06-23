

/*
        Наряд_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class Наряд_Triggers
{
    public static async Task New(Наряд_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.Наряд();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.Наряд(++number)).ToString("D8");
                    
    }

    public static Task Copying(Наряд_Object ДокументОбєкт, Наряд_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Наряд_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Наряд_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(Наряд_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Наряд_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Наряд_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    