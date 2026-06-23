

/*
        ТипиБухОперацій_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ТипиБухОперацій_Triggers
{
    public static async Task New(ТипиБухОперацій_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ТипиБухОперацій();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ТипиБухОперацій(++number)).ToString("D6");
    }

    public static Task Copying(ТипиБухОперацій_Object ДовідникОбєкт, ТипиБухОперацій_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ТипиБухОперацій_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ТипиБухОперацій_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ТипиБухОперацій_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ТипиБухОперацій_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
