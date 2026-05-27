
/*
    БанківськіРахункиКонтрагентів_Triggers.cs
    Тригери для довідника БанківськіРахункиКонтрагентів
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class БанківськіРахункиКонтрагентів_Triggers
{
    public static Task New(БанківськіРахункиКонтрагентів_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.БанківськіРахункиКонтрагентів_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(БанківськіРахункиКонтрагентів_Objest ДовідникОбєкт, БанківськіРахункиКонтрагентів_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(БанківськіРахункиКонтрагентів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(БанківськіРахункиКонтрагентів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(БанківськіРахункиКонтрагентів_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(БанківськіРахункиКонтрагентів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
