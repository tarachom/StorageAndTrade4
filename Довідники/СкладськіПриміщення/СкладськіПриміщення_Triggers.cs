
/*
    СкладськіПриміщення_Triggers.cs
    Тригери для довідника СкладськіПриміщення
*/

namespace GeneratedCode.Довідники;

class СкладськіПриміщення_Triggers
{
    public static Task New(СкладськіПриміщення_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(СкладськіПриміщення_Object ДовідникОбєкт, СкладськіПриміщення_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СкладськіПриміщення_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(СкладськіПриміщення_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СкладськіПриміщення_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СкладськіПриміщення_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
