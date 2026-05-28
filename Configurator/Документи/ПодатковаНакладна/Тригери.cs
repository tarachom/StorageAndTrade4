

/*
        ПодатковаНакладна_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПодатковаНакладна_Triggers
{
    public static async Task New(ПодатковаНакладна_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПодатковаНакладна();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПодатковаНакладна(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПодатковаНакладна_Objest ДокументОбєкт, ПодатковаНакладна_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПодатковаНакладна_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПодатковаНакладна_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПодатковаНакладна_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПодатковаНакладна_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПодатковаНакладна_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    