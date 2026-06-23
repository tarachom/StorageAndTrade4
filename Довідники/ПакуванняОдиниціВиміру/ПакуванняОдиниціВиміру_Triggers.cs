
/*
    ПакуванняОдиниціВиміру_Triggers.cs
    Тригери для довідника ПакуванняОдиниціВиміру
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ПакуванняОдиниціВиміру_Triggers
{
    public static async Task New(ПакуванняОдиниціВиміру_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ПакуванняОдиниціВиміру();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ПакуванняОдиниціВиміру(++number)).ToString("D6");
    }

    public static Task Copying(ПакуванняОдиниціВиміру_Object ДовідникОбєкт, ПакуванняОдиниціВиміру_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПакуванняОдиниціВиміру_Object ДовідникОбєкт)
    {
        if (ДовідникОбєкт.КількістьУпаковок <= 0) ДовідникОбєкт.КількістьУпаковок = 1;
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПакуванняОдиниціВиміру_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПакуванняОдиниціВиміру_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПакуванняОдиниціВиміру_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
