

/*
        КасиККМ_Triggers.cs
        Тригери
*/

namespace GeneratedCode.Довідники;

static class КасиККМ_Triggers
{
    public static Task New(КасиККМ_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(КасиККМ_Object ДовідникОбєкт, КасиККМ_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(КасиККМ_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(КасиККМ_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(КасиККМ_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(КасиККМ_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
