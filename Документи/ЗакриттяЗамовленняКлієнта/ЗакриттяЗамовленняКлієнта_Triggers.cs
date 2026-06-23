
/*
    ЗакриттяЗамовленняКлієнта_Triggers.cs
    Тригери для документу ЗакриттяЗамовленняКлієнта
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ЗакриттяЗамовленняКлієнта_Triggers
{
    public static async Task New(ЗакриттяЗамовленняКлієнта_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ЗакриттяЗамовленняКлієнта();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗакриттяЗамовленняКлієнта(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;
    }

    public static Task Copying(ЗакриттяЗамовленняКлієнта_Object ДокументОбєкт, ЗакриттяЗамовленняКлієнта_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗакриттяЗамовленняКлієнта_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗакриттяЗамовленняКлієнта_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗакриттяЗамовленняКлієнта_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗакриттяЗамовленняКлієнта_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗакриттяЗамовленняКлієнта_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
