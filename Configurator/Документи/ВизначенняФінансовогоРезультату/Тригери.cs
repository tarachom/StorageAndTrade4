

/*
        ВизначенняФінансовогоРезультату_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ВизначенняФінансовогоРезультату_Triggers
{
    public static async Task New(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ВизначенняФінансовогоРезультату();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ВизначенняФінансовогоРезультату(++number)).ToString("D8");
                    
    }

    public static Task Copying(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт, ВизначенняФінансовогоРезультату_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ВизначенняФінансовогоРезультату_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    