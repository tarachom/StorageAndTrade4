

/*
        Бланки_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class Бланки_Triggers
{
    public static async Task New(Бланки_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Бланки();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Бланки(++number)).ToString("D6");
    }

    public static Task Copying(Бланки_Object ДовідникОбєкт, Бланки_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Бланки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Бланки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Бланки_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Бланки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
