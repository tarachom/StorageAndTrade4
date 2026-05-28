

/*
        ПрибуткуванняТоварівВПереробку_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПрибуткуванняТоварівВПереробку_Triggers
{
    public static async Task New(ПрибуткуванняТоварівВПереробку_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПрибуткуванняТоварівВПереробку();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПрибуткуванняТоварівВПереробку(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПрибуткуванняТоварівВПереробку_Objest ДокументОбєкт, ПрибуткуванняТоварівВПереробку_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПрибуткуванняТоварівВПереробку_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрибуткуванняТоварівВПереробку_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПрибуткуванняТоварівВПереробку_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрибуткуванняТоварівВПереробку_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрибуткуванняТоварівВПереробку_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    