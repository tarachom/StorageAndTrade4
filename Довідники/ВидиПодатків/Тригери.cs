

/*
        ВидиПодатків_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

static class ВидиПодатків_Triggers
{
    public static async Task New(ВидиПодатків_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ВидиПодатків();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ВидиПодатків(++number)).ToString("D6");
    }

    public static Task Copying(ВидиПодатків_Object ДовідникОбєкт, ВидиПодатків_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиПодатків_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиПодатків_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиПодатків_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиПодатків_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
