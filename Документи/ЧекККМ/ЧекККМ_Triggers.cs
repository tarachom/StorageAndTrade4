

/*
        ЧекККМ_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

static class ЧекККМ_Triggers
{
    public static async Task New(ЧекККМ_Objest ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ЧекККМ();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЧекККМ(++number)).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(ЧекККМ_Objest ДокументОбєкт, ЧекККМ_Objest Основа)
    {

        ДокументОбєкт.Назва += " - Копія";

        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЧекККМ_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЧекККМ_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЧекККМ_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЧекККМ_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЧекККМ_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
