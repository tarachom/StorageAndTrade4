

/*
        АвансовийЗвіт_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class АвансовийЗвіт_Triggers
{
    public static async Task New(АвансовийЗвіт_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;

        int number = await НумераціяДокументів.АвансовийЗвіт();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.АвансовийЗвіт(++number)).ToString("D8");
    }

    public static Task Copying(АвансовийЗвіт_Objest ДокументОбєкт, АвансовийЗвіт_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(АвансовийЗвіт_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{АвансовийЗвіт_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(АвансовийЗвіт_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(АвансовийЗвіт_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(АвансовийЗвіт_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
