

/*
        ПоверненняПереданихТоварів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПоверненняПереданихТоварів_Triggers
{
    public static async Task New(ПоверненняПереданихТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПоверненняПереданихТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПоверненняПереданихТоварів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПоверненняПереданихТоварів_Object ДокументОбєкт, ПоверненняПереданихТоварів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПоверненняПереданихТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПоверненняПереданихТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПоверненняПереданихТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПоверненняПереданихТоварів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПоверненняПереданихТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    