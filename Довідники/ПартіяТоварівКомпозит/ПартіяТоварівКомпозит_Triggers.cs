
/*
    ПартіяТоварівКомпозит_Triggers.cs
    Тригери для довідника ПартіяТоварівКомпозит
*/

namespace GeneratedCode.Довідники;

class ПартіяТоварівКомпозит_Triggers
{
    public static Task New(ПартіяТоварівКомпозит_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(ПартіяТоварівКомпозит_Objest ДовідникОбєкт, ПартіяТоварівКомпозит_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПартіяТоварівКомпозит_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПартіяТоварівКомпозит_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПартіяТоварівКомпозит_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПартіяТоварівКомпозит_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
