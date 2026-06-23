

/*
        ПослугиСторонньоїОрганізації_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПослугиСторонньоїОрганізації_Triggers
{
    public static async Task New(ПослугиСторонньоїОрганізації_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПослугиСторонньоїОрганізації();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПослугиСторонньоїОрганізації(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПослугиСторонньоїОрганізації_Object ДокументОбєкт, ПослугиСторонньоїОрганізації_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПослугиСторонньоїОрганізації_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПослугиСторонньоїОрганізації_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПослугиСторонньоїОрганізації_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПослугиСторонньоїОрганізації_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПослугиСторонньоїОрганізації_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    