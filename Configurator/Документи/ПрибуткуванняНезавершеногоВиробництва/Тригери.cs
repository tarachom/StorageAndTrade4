

/*
        ПрибуткуванняНезавершеногоВиробництва_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПрибуткуванняНезавершеногоВиробництва_Triggers
{
    public static async Task New(ПрибуткуванняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПрибуткуванняНезавершеногоВиробництва();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПрибуткуванняНезавершеногоВиробництва(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПрибуткуванняНезавершеногоВиробництва_Objest ДокументОбєкт, ПрибуткуванняНезавершеногоВиробництва_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПрибуткуванняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрибуткуванняНезавершеногоВиробництва_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПрибуткуванняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрибуткуванняНезавершеногоВиробництва_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрибуткуванняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    