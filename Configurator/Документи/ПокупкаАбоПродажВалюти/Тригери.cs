

/*
        ПокупкаАбоПродажВалюти_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПокупкаАбоПродажВалюти_Triggers
{
    public static async Task New(ПокупкаАбоПродажВалюти_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПокупкаАбоПродажВалюти();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПокупкаАбоПродажВалюти(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПокупкаАбоПродажВалюти_Objest ДокументОбєкт, ПокупкаАбоПродажВалюти_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПокупкаАбоПродажВалюти_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПокупкаАбоПродажВалюти_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПокупкаАбоПродажВалюти_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПокупкаАбоПродажВалюти_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПокупкаАбоПродажВалюти_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    