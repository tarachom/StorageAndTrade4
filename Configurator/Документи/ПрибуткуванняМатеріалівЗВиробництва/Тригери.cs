

/*
        ПрибуткуванняМатеріалівЗВиробництва_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПрибуткуванняМатеріалівЗВиробництва_Triggers
{
    public static async Task New(ПрибуткуванняМатеріалівЗВиробництва_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПрибуткуванняМатеріалівЗВиробництва();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПрибуткуванняМатеріалівЗВиробництва(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПрибуткуванняМатеріалівЗВиробництва_Object ДокументОбєкт, ПрибуткуванняМатеріалівЗВиробництва_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПрибуткуванняМатеріалівЗВиробництва_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрибуткуванняМатеріалівЗВиробництва_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПрибуткуванняМатеріалівЗВиробництва_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрибуткуванняМатеріалівЗВиробництва_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрибуткуванняМатеріалівЗВиробництва_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    