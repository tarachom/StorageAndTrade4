

/*
        Співробітники_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

static class Співробітники_Triggers
{
    public static async Task New(Співробітники_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Співробітники();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Співробітники(++number)).ToString("D6");
    }

    public static Task Copying(Співробітники_Objest ДовідникОбєкт, Співробітники_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Співробітники_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Співробітники_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Співробітники_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Співробітники_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
