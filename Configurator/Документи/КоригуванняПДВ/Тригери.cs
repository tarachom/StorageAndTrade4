

/*
        КоригуванняПДВ_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class КоригуванняПДВ_Triggers
{
    public static async Task New(КоригуванняПДВ_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.КоригуванняПДВ();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.КоригуванняПДВ(++number)).ToString("D8");
                    
    }

    public static Task Copying(КоригуванняПДВ_Objest ДокументОбєкт, КоригуванняПДВ_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(КоригуванняПДВ_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{КоригуванняПДВ_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(КоригуванняПДВ_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(КоригуванняПДВ_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(КоригуванняПДВ_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    