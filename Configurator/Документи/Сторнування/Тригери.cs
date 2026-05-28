

/*
        Сторнування_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class Сторнування_Triggers
{
    public static async Task New(Сторнування_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.Сторнування();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.Сторнування(++number)).ToString("D8");
                    
    }

    public static Task Copying(Сторнування_Objest ДокументОбєкт, Сторнування_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Сторнування_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Сторнування_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(Сторнування_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Сторнування_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Сторнування_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    