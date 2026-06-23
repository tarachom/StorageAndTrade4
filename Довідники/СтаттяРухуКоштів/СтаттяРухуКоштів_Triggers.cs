
/*
    СтаттяРухуКоштів_Triggers.cs
    Тригери для довідника СтаттяРухуКоштів
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class СтаттяРухуКоштів_Triggers
{
    public static async Task New(СтаттяРухуКоштів_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.СтаттяРухуКоштів();
        ДовідникОбєкт.Код = (await НумераціяДовідників.СтаттяРухуКоштів(++number)).ToString("D6");
    }

    public static Task Copying(СтаттяРухуКоштів_Object ДовідникОбєкт, СтаттяРухуКоштів_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СтаттяРухуКоштів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(СтаттяРухуКоштів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СтаттяРухуКоштів_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СтаттяРухуКоштів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}