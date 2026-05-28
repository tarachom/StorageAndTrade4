

/*
        ГрошовіРахункиВласні_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ГрошовіРахункиВласні_Triggers
{
    public static async Task New(ГрошовіРахункиВласні_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ГрошовіРахункиВласні();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ГрошовіРахункиВласні(++number)).ToString("D6");
    }

    public static Task Copying(ГрошовіРахункиВласні_Objest ДовідникОбєкт, ГрошовіРахункиВласні_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ГрошовіРахункиВласні_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ГрошовіРахункиВласні_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ГрошовіРахункиВласні_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ГрошовіРахункиВласні_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
