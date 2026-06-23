
/*
    СкладськіКомірки_Triggers.cs
    Тригери для довідника СкладськіКомірки
*/

namespace GeneratedCode.Довідники;

class СкладськіКомірки_Triggers
{
    public static Task New(СкладськіКомірки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(СкладськіКомірки_Object ДовідникОбєкт, СкладськіКомірки_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СкладськіКомірки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(СкладськіКомірки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СкладськіКомірки_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СкладськіКомірки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
