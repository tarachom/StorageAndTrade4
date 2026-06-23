
/*
    БанківськіРахункиКонтрагентів_Triggers.cs
    Тригери для довідника БанківськіРахункиКонтрагентів
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class БанківськіРахункиКонтрагентів_Triggers
{
    public static async Task New(БанківськіРахункиКонтрагентів_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.БанківськіРахункиКонтрагентів();
        ДовідникОбєкт.Код = (await НумераціяДовідників.БанківськіРахункиКонтрагентів(++number)).ToString("D6");
    }

    public static Task Copying(БанківськіРахункиКонтрагентів_Object ДовідникОбєкт, БанківськіРахункиКонтрагентів_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(БанківськіРахункиКонтрагентів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(БанківськіРахункиКонтрагентів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(БанківськіРахункиКонтрагентів_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(БанківськіРахункиКонтрагентів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
