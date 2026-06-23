

/*
        КоригуванняІншихВитрат_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class КоригуванняІншихВитрат_Triggers
{
    public static async Task New(КоригуванняІншихВитрат_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.КоригуванняІншихВитрат();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.КоригуванняІншихВитрат(++number)).ToString("D8");
                    
    }

    public static Task Copying(КоригуванняІншихВитрат_Object ДокументОбєкт, КоригуванняІншихВитрат_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(КоригуванняІншихВитрат_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{КоригуванняІншихВитрат_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(КоригуванняІншихВитрат_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(КоригуванняІншихВитрат_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(КоригуванняІншихВитрат_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    