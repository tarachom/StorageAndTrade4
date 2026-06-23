

/*
        Співробітники_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

static class Співробітники_Triggers
{
    public static async Task New(Співробітники_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Співробітники();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Співробітники(++number)).ToString("D6");
    }

    public static Task Copying(Співробітники_Object ДовідникОбєкт, Співробітники_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Співробітники_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Співробітники_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Співробітники_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Співробітники_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
