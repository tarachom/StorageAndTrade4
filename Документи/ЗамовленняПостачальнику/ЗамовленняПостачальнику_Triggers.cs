
/*
    ЗамовленняПостачальнику_Triggers.cs
    Тригери для документу ЗамовленняПостачальнику
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ЗамовленняПостачальнику_Triggers
{
    public static async Task New(ЗамовленняПостачальнику_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ЗамовленняПостачальнику();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗамовленняПостачальнику(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;
    }

    public static Task Copying(ЗамовленняПостачальнику_Object ДокументОбєкт, ЗамовленняПостачальнику_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗамовленняПостачальнику_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗамовленняПостачальнику_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗамовленняПостачальнику_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗамовленняПостачальнику_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗамовленняПостачальнику_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}