

/*
        СписанняТоварів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняТоварів_Triggers
{
    public static async Task New(СписанняТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняТоварів(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняТоварів_Objest ДокументОбєкт, СписанняТоварів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняТоварів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    