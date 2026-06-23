

/*
        ПрибуткуванняНезавершеногоВиробництва_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПрибуткуванняНезавершеногоВиробництва_Triggers
{
    public static async Task New(ПрибуткуванняНезавершеногоВиробництва_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПрибуткуванняНезавершеногоВиробництва();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПрибуткуванняНезавершеногоВиробництва(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПрибуткуванняНезавершеногоВиробництва_Object ДокументОбєкт, ПрибуткуванняНезавершеногоВиробництва_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПрибуткуванняНезавершеногоВиробництва_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрибуткуванняНезавершеногоВиробництва_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПрибуткуванняНезавершеногоВиробництва_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрибуткуванняНезавершеногоВиробництва_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрибуткуванняНезавершеногоВиробництва_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    