
/*
    СкладськіКомірки_Triggers.cs
    Тригери для довідника СкладськіКомірки
*/

namespace GeneratedCode.Довідники;

class СкладськіКомірки_Triggers
{
    public static Task New(СкладськіКомірки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(СкладськіКомірки_Objest ДовідникОбєкт, СкладськіКомірки_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СкладськіКомірки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(СкладськіКомірки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СкладськіКомірки_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СкладськіКомірки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
