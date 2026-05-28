

/*
        НакладнаВимога_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class НакладнаВимога_Triggers
{
    public static async Task New(НакладнаВимога_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.НакладнаВимога();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.НакладнаВимога(++number)).ToString("D8");
                    
    }

    public static Task Copying(НакладнаВимога_Objest ДокументОбєкт, НакладнаВимога_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(НакладнаВимога_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{НакладнаВимога_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(НакладнаВимога_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(НакладнаВимога_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(НакладнаВимога_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    