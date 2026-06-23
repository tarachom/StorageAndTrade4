

/*
        ПрибуткуванняТоварівВПереробку_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПрибуткуванняТоварівВПереробку_Triggers
{
    public static async Task New(ПрибуткуванняТоварівВПереробку_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПрибуткуванняТоварівВПереробку();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПрибуткуванняТоварівВПереробку(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПрибуткуванняТоварівВПереробку_Object ДокументОбєкт, ПрибуткуванняТоварівВПереробку_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПрибуткуванняТоварівВПереробку_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрибуткуванняТоварівВПереробку_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПрибуткуванняТоварівВПереробку_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрибуткуванняТоварівВПереробку_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрибуткуванняТоварівВПереробку_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    