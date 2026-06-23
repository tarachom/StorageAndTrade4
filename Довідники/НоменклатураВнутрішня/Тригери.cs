

/*
        НоменклатураВнутрішня_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class НоменклатураВнутрішня_Triggers
{
    public static async Task New(НоменклатураВнутрішня_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.НоменклатураВнутрішня();
        ДовідникОбєкт.Код = (await НумераціяДовідників.НоменклатураВнутрішня(++number)).ToString("D6");
    }

    public static Task Copying(НоменклатураВнутрішня_Object ДовідникОбєкт, НоменклатураВнутрішня_Object Основа)
    {

        ДовідникОбєкт.Назва += " - Копія";

        return Task.CompletedTask;
    }

    public static Task BeforeSave(НоменклатураВнутрішня_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(НоменклатураВнутрішня_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(НоменклатураВнутрішня_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(НоменклатураВнутрішня_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
