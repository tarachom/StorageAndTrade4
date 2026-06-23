
/*
    ВидиЦінПостачальників_Triggers.cs
    Тригери для довідника ВидиЦінПостачальників
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ВидиЦінПостачальників_Triggers
{
    public static async Task New(ВидиЦінПостачальників_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ВидиЦінПостачальників();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ВидиЦінПостачальників(++number)).ToString("D6");
    }

    public static Task Copying(ВидиЦінПостачальників_Object ДовідникОбєкт, ВидиЦінПостачальників_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиЦінПостачальників_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиЦінПостачальників_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиЦінПостачальників_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиЦінПостачальників_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}