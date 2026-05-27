
/*
    ЗамовленняПостачальнику_Triggers.cs
    Тригери для документу ЗамовленняПостачальнику
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ЗамовленняПостачальнику_Triggers
{
    public static Task New(ЗамовленняПостачальнику_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.ЗамовленняПостачальнику_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(ЗамовленняПостачальнику_Objest ДокументОбєкт, ЗамовленняПостачальнику_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗамовленняПостачальнику_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗамовленняПостачальнику_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗамовленняПостачальнику_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗамовленняПостачальнику_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗамовленняПостачальнику_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}