

/*
        КасиККМ_Triggers.cs
        Тригери
*/

namespace GeneratedCode.Довідники;

static class КасиККМ_Triggers
{
    public static Task New(КасиККМ_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(КасиККМ_Objest ДовідникОбєкт, КасиККМ_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(КасиККМ_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(КасиККМ_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(КасиККМ_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(КасиККМ_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
