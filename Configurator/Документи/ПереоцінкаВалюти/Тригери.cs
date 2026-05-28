

/*
        ПереоцінкаВалюти_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПереоцінкаВалюти_Triggers
{
    public static async Task New(ПереоцінкаВалюти_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПереоцінкаВалюти();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПереоцінкаВалюти(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПереоцінкаВалюти_Objest ДокументОбєкт, ПереоцінкаВалюти_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереоцінкаВалюти_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереоцінкаВалюти_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереоцінкаВалюти_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереоцінкаВалюти_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереоцінкаВалюти_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    