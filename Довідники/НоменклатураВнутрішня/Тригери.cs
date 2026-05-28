

/*
        НоменклатураВнутрішня_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class НоменклатураВнутрішня_Triggers
{
    public static async Task New(НоменклатураВнутрішня_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.НоменклатураВнутрішня();
        ДовідникОбєкт.Код = (await НумераціяДовідників.НоменклатураВнутрішня(++number)).ToString("D6");
    }

    public static Task Copying(НоменклатураВнутрішня_Objest ДовідникОбєкт, НоменклатураВнутрішня_Objest Основа)
    {

        ДовідникОбєкт.Назва += " - Копія";

        return Task.CompletedTask;
    }

    public static Task BeforeSave(НоменклатураВнутрішня_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(НоменклатураВнутрішня_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(НоменклатураВнутрішня_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(НоменклатураВнутрішня_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
