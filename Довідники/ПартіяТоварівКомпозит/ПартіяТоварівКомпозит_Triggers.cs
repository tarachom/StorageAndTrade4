
/*
    ПартіяТоварівКомпозит_Triggers.cs
    Тригери для довідника ПартіяТоварівКомпозит
*/

namespace GeneratedCode.Довідники;

class ПартіяТоварівКомпозит_Triggers
{
    public static Task New(ПартіяТоварівКомпозит_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(ПартіяТоварівКомпозит_Object ДовідникОбєкт, ПартіяТоварівКомпозит_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПартіяТоварівКомпозит_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПартіяТоварівКомпозит_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПартіяТоварівКомпозит_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПартіяТоварівКомпозит_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
