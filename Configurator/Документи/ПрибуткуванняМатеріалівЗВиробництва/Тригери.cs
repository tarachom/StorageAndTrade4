

/*
        ПрибуткуванняМатеріалівЗВиробництва_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПрибуткуванняМатеріалівЗВиробництва_Triggers
{
    public static async Task New(ПрибуткуванняМатеріалівЗВиробництва_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПрибуткуванняМатеріалівЗВиробництва();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПрибуткуванняМатеріалівЗВиробництва(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПрибуткуванняМатеріалівЗВиробництва_Objest ДокументОбєкт, ПрибуткуванняМатеріалівЗВиробництва_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПрибуткуванняМатеріалівЗВиробництва_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрибуткуванняМатеріалівЗВиробництва_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПрибуткуванняМатеріалівЗВиробництва_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрибуткуванняМатеріалівЗВиробництва_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрибуткуванняМатеріалівЗВиробництва_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    