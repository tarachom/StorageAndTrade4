

/*
        Магазини_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class Магазини_Triggers
{
    public static  Task New(Магазини_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        return Task.CompletedTask;
                    
    }

    public static Task Copying(Магазини_Object ДокументОбєкт, Магазини_Object Підстава)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Магазини_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Магазини_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(Магазини_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Магазини_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Магазини_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    