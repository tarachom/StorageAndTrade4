

/*
        Співробітники_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

static class Співробітники_Triggers
{
    public static Task New(Співробітники_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Співробітники_Const).ToString("D6");
        return Task.CompletedTask;
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
