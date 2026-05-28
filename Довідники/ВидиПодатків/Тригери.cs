

/*
        ВидиПодатків_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

static class ВидиПодатків_Triggers
{
    public static async Task New(ВидиПодатків_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ВидиПодатків();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ВидиПодатків(++number)).ToString("D6");
    }

    public static Task Copying(ВидиПодатків_Objest ДовідникОбєкт, ВидиПодатків_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиПодатків_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиПодатків_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиПодатків_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиПодатків_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
