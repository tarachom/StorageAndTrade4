
/*
    ВидиЦінПостачальників_Triggers.cs
    Тригери для довідника ВидиЦінПостачальників
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ВидиЦінПостачальників_Triggers
{
    public static async Task New(ВидиЦінПостачальників_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ВидиЦінПостачальників();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ВидиЦінПостачальників(++number)).ToString("D6");
    }

    public static Task Copying(ВидиЦінПостачальників_Objest ДовідникОбєкт, ВидиЦінПостачальників_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиЦінПостачальників_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиЦінПостачальників_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиЦінПостачальників_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиЦінПостачальників_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}