
/*
    СтаттяРухуКоштів_Triggers.cs
    Тригери для довідника СтаттяРухуКоштів
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class СтаттяРухуКоштів_Triggers
{
    public static Task New(СтаттяРухуКоштів_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.СтаттяРухуКоштів_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(СтаттяРухуКоштів_Objest ДовідникОбєкт, СтаттяРухуКоштів_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СтаттяРухуКоштів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(СтаттяРухуКоштів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СтаттяРухуКоштів_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СтаттяРухуКоштів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}