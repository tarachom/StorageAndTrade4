

/*
        РозподілІншихВитрат_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class РозподілІншихВитрат_Triggers
{
    public static async Task New(РозподілІншихВитрат_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.РозподілІншихВитрат();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.РозподілІншихВитрат(++number)).ToString("D8");
                    
    }

    public static Task Copying(РозподілІншихВитрат_Objest ДокументОбєкт, РозподілІншихВитрат_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РозподілІншихВитрат_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РозподілІншихВитрат_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РозподілІншихВитрат_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РозподілІншихВитрат_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РозподілІншихВитрат_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    