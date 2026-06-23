

/*
        ПереоцінкаТоварів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПереоцінкаТоварів_Triggers
{
    public static async Task New(ПереоцінкаТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПереоцінкаТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПереоцінкаТоварів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПереоцінкаТоварів_Object ДокументОбєкт, ПереоцінкаТоварів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереоцінкаТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереоцінкаТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереоцінкаТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереоцінкаТоварів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереоцінкаТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    