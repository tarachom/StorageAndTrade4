

/*
        Додаток1ДоПодатковоїНакладної_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class Додаток1ДоПодатковоїНакладної_Triggers
{
    public static async Task New(Додаток1ДоПодатковоїНакладної_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.Додаток1ДоПодатковоїНакладної();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.Додаток1ДоПодатковоїНакладної(++number)).ToString("D8");
                    
    }

    public static Task Copying(Додаток1ДоПодатковоїНакладної_Object ДокументОбєкт, Додаток1ДоПодатковоїНакладної_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Додаток1ДоПодатковоїНакладної_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Додаток1ДоПодатковоїНакладної_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(Додаток1ДоПодатковоїНакладної_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Додаток1ДоПодатковоїНакладної_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Додаток1ДоПодатковоїНакладної_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    