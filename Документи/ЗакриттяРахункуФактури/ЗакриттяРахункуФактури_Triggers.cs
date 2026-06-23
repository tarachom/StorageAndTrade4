
/*
    ЗакриттяРахункуФактури_Triggers.cs
    Тригери для документу ЗакриттяРахункуФактури
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ЗакриттяРахункуФактури_Triggers
{
    public static async Task New(ЗакриттяРахункуФактури_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ЗакриттяРахункуФактури();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗакриттяРахункуФактури(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;
    }

    public static Task Copying(ЗакриттяРахункуФактури_Object ДокументОбєкт, ЗакриттяРахункуФактури_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗакриттяРахункуФактури_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗакриттяРахункуФактури_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗакриттяРахункуФактури_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗакриттяРахункуФактури_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗакриттяРахункуФактури_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
