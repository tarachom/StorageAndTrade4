

/*
        РозподілІншихВитрат_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class РозподілІншихВитрат_Triggers
{
    public static async Task New(РозподілІншихВитрат_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.РозподілІншихВитрат();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.РозподілІншихВитрат(++number)).ToString("D8");
                    
    }

    public static Task Copying(РозподілІншихВитрат_Object ДокументОбєкт, РозподілІншихВитрат_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РозподілІншихВитрат_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РозподілІншихВитрат_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РозподілІншихВитрат_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РозподілІншихВитрат_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РозподілІншихВитрат_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    