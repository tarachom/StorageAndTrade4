

/*
        Додаток2ДоПодатковоїНакладної_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class Додаток2ДоПодатковоїНакладної_Triggers
{
    public static  Task New(Додаток2ДоПодатковоїНакладної_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        return Task.CompletedTask;
                    
    }

    public static Task Copying(Додаток2ДоПодатковоїНакладної_Objest ДокументОбєкт, Додаток2ДоПодатковоїНакладної_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Додаток2ДоПодатковоїНакладної_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Додаток2ДоПодатковоїНакладної_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(Додаток2ДоПодатковоїНакладної_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Додаток2ДоПодатковоїНакладної_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Додаток2ДоПодатковоїНакладної_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    