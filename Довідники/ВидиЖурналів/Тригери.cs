

/*
        ВидиЖурналів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ВидиЖурналів_Triggers
{
    public static async Task New(ВидиЖурналів_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ВидиЖурналів();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ВидиЖурналів(++number)).ToString("D6");
    }

    public static Task Copying(ВидиЖурналів_Object ДовідникОбєкт, ВидиЖурналів_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиЖурналів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиЖурналів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиЖурналів_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиЖурналів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
