
/*
    СкладськіПриміщення_Triggers.cs
    Тригери для довідника СкладськіПриміщення
*/

namespace GeneratedCode.Довідники;

class СкладськіПриміщення_Triggers
{
    public static Task New(СкладськіПриміщення_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(СкладськіПриміщення_Objest ДовідникОбєкт, СкладськіПриміщення_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СкладськіПриміщення_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(СкладськіПриміщення_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СкладськіПриміщення_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СкладськіПриміщення_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
