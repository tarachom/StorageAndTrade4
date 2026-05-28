

/*
        СписанняМатеріалів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняМатеріалів_Triggers
{
    public static async Task New(СписанняМатеріалів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняМатеріалів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняМатеріалів(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняМатеріалів_Objest ДокументОбєкт, СписанняМатеріалів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняМатеріалів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняМатеріалів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняМатеріалів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняМатеріалів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняМатеріалів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    