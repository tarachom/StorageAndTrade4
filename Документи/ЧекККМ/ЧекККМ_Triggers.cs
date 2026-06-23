

/*
        ЧекККМ_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

static class ЧекККМ_Triggers
{
    public static async Task New(ЧекККМ_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ЧекККМ();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЧекККМ(++number)).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(ЧекККМ_Object ДокументОбєкт, ЧекККМ_Object Основа)
    {

        ДокументОбєкт.Назва += " - Копія";

        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЧекККМ_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЧекККМ_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЧекККМ_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЧекККМ_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЧекККМ_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
