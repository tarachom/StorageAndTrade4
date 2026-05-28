

/*
        ПоверненняПереданихТоварів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПоверненняПереданихТоварів_Triggers
{
    public static async Task New(ПоверненняПереданихТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПоверненняПереданихТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПоверненняПереданихТоварів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПоверненняПереданихТоварів_Objest ДокументОбєкт, ПоверненняПереданихТоварів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПоверненняПереданихТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПоверненняПереданихТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПоверненняПереданихТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПоверненняПереданихТоварів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПоверненняПереданихТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    