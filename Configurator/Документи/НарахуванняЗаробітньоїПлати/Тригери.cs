

/*
        НарахуванняЗаробітньоїПлати_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class НарахуванняЗаробітньоїПлати_Triggers
{
    public static async Task New(НарахуванняЗаробітньоїПлати_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.НарахуванняЗаробітньоїПлати();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.НарахуванняЗаробітньоїПлати(++number)).ToString("D8");
                    
    }

    public static Task Copying(НарахуванняЗаробітньоїПлати_Object ДокументОбєкт, НарахуванняЗаробітньоїПлати_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(НарахуванняЗаробітньоїПлати_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{НарахуванняЗаробітньоїПлати_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(НарахуванняЗаробітньоїПлати_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(НарахуванняЗаробітньоїПлати_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(НарахуванняЗаробітньоїПлати_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    