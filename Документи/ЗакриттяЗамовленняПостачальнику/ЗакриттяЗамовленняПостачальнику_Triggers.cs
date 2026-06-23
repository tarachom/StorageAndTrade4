
/*
    ЗакриттяЗамовленняПостачальнику_Triggers.cs
    Тригери для документу ЗакриттяЗамовленняПостачальнику
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Документи;

class ЗакриттяЗамовленняПостачальнику_Triggers
{
    public static async Task New(ЗакриттяЗамовленняПостачальнику_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ЗакриттяЗамовленняПостачальнику();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗакриттяЗамовленняПостачальнику(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
    }

    public static Task Copying(ЗакриттяЗамовленняПостачальнику_Object ДокументОбєкт, ЗакриттяЗамовленняПостачальнику_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗакриттяЗамовленняПостачальнику_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗакриттяЗамовленняПостачальнику_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗакриттяЗамовленняПостачальнику_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗакриттяЗамовленняПостачальнику_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗакриттяЗамовленняПостачальнику_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}