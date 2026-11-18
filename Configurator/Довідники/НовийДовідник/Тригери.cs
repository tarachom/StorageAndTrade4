

/*
        НовийДовідник_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class НовийДовідник_Triggers
{
    public static  Task New(НовийДовідник_Object ДовідникОбєкт)
    {
        
        return Task.CompletedTask;
              
    }

    public static Task Copying(НовийДовідник_Object ДовідникОбєкт, НовийДовідник_Object Підстава)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(НовийДовідник_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(НовийДовідник_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(НовийДовідник_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(НовийДовідник_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
    