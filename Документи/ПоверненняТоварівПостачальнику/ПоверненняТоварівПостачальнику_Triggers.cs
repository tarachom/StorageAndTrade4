
/*
    ПоверненняТоварівПостачальнику_Triggers.cs
    Тригери для документу ПоверненняТоварівПостачальнику
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПоверненняТоварівПостачальнику_Triggers
{
    public static Task New(ПоверненняТоварівПостачальнику_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.ПоверненняТоварівПостачальнику_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(ПоверненняТоварівПостачальнику_Objest ДокументОбєкт, ПоверненняТоварівПостачальнику_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПоверненняТоварівПостачальнику_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПоверненняТоварівПостачальнику_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПоверненняТоварівПостачальнику_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПоверненняТоварівПостачальнику_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПоверненняТоварівПостачальнику_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
