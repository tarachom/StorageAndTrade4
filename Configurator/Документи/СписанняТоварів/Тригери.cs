

/*
        СписанняТоварів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняТоварів_Triggers
{
    public static async Task New(СписанняТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняТоварів(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняТоварів_Object ДокументОбєкт, СписанняТоварів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняТоварів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    