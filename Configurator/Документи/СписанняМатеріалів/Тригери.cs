

/*
        СписанняМатеріалів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняМатеріалів_Triggers
{
    public static async Task New(СписанняМатеріалів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняМатеріалів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняМатеріалів(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняМатеріалів_Object ДокументОбєкт, СписанняМатеріалів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняМатеріалів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняМатеріалів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняМатеріалів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняМатеріалів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняМатеріалів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    