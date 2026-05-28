

/*
        ПередачаТоварів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПередачаТоварів_Triggers
{
    public static async Task New(ПередачаТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПередачаТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПередачаТоварів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПередачаТоварів_Objest ДокументОбєкт, ПередачаТоварів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПередачаТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПередачаТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПередачаТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПередачаТоварів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПередачаТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    