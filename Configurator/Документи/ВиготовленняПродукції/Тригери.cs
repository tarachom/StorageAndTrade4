

/*
        ВиготовленняПродукції_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ВиготовленняПродукції_Triggers
{
    public static async Task New(ВиготовленняПродукції_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ВиготовленняПродукції();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ВиготовленняПродукції(++number)).ToString("D8");
                    
    }

    public static Task Copying(ВиготовленняПродукції_Objest ДокументОбєкт, ВиготовленняПродукції_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВиготовленняПродукції_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ВиготовленняПродукції_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВиготовленняПродукції_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВиготовленняПродукції_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВиготовленняПродукції_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    