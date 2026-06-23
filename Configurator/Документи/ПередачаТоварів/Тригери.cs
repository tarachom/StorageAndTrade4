

/*
        ПередачаТоварів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПередачаТоварів_Triggers
{
    public static async Task New(ПередачаТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПередачаТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПередачаТоварів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПередачаТоварів_Object ДокументОбєкт, ПередачаТоварів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПередачаТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПередачаТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПередачаТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПередачаТоварів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПередачаТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    