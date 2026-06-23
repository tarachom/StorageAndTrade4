

/*
        Сторнування_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class Сторнування_Triggers
{
    public static async Task New(Сторнування_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.Сторнування();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.Сторнування(++number)).ToString("D8");
                    
    }

    public static Task Copying(Сторнування_Object ДокументОбєкт, Сторнування_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Сторнування_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Сторнування_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(Сторнування_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Сторнування_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Сторнування_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    