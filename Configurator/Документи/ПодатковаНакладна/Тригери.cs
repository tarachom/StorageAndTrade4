

/*
        ПодатковаНакладна_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПодатковаНакладна_Triggers
{
    public static async Task New(ПодатковаНакладна_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПодатковаНакладна();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПодатковаНакладна(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПодатковаНакладна_Object ДокументОбєкт, ПодатковаНакладна_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПодатковаНакладна_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПодатковаНакладна_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПодатковаНакладна_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПодатковаНакладна_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПодатковаНакладна_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    