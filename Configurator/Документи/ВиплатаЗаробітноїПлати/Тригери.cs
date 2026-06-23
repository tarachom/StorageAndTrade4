

/*
        ВиплатаЗаробітноїПлати_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ВиплатаЗаробітноїПлати_Triggers
{
    public static async Task New(ВиплатаЗаробітноїПлати_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ВиплатаЗаробітноїПлати();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ВиплатаЗаробітноїПлати(++number)).ToString("D8");
                    
    }

    public static Task Copying(ВиплатаЗаробітноїПлати_Object ДокументОбєкт, ВиплатаЗаробітноїПлати_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВиплатаЗаробітноїПлати_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ВиплатаЗаробітноїПлати_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВиплатаЗаробітноїПлати_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВиплатаЗаробітноїПлати_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВиплатаЗаробітноїПлати_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    