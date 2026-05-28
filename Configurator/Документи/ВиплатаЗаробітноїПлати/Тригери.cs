

/*
        ВиплатаЗаробітноїПлати_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ВиплатаЗаробітноїПлати_Triggers
{
    public static async Task New(ВиплатаЗаробітноїПлати_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ВиплатаЗаробітноїПлати();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ВиплатаЗаробітноїПлати(++number)).ToString("D8");
                    
    }

    public static Task Copying(ВиплатаЗаробітноїПлати_Objest ДокументОбєкт, ВиплатаЗаробітноїПлати_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВиплатаЗаробітноїПлати_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ВиплатаЗаробітноїПлати_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВиплатаЗаробітноїПлати_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВиплатаЗаробітноїПлати_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВиплатаЗаробітноїПлати_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    