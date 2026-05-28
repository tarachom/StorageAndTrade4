

/*
        ПрибуткуванняТоварівЗПереробки_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПрибуткуванняТоварівЗПереробки_Triggers
{
    public static async Task New(ПрибуткуванняТоварівЗПереробки_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПрибуткуванняТоварівЗПереробки();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПрибуткуванняТоварівЗПереробки(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПрибуткуванняТоварівЗПереробки_Objest ДокументОбєкт, ПрибуткуванняТоварівЗПереробки_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПрибуткуванняТоварівЗПереробки_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрибуткуванняТоварівЗПереробки_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПрибуткуванняТоварівЗПереробки_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрибуткуванняТоварівЗПереробки_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрибуткуванняТоварівЗПереробки_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    