

/*
        Наряд_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class Наряд_Triggers
{
    public static async Task New(Наряд_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.Наряд();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.Наряд(++number)).ToString("D8");
                    
    }

    public static Task Copying(Наряд_Objest ДокументОбєкт, Наряд_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Наряд_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Наряд_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(Наряд_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Наряд_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Наряд_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    