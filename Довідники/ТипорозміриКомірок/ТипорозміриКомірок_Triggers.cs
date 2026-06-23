
/*
    ТипорозміриКомірок_Triggers.cs
    Тригери для довідника ТипорозміриКомірок
*/

namespace GeneratedCode.Довідники;

class ТипорозміриКомірок_Triggers
{
    public static Task New(ТипорозміриКомірок_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(ТипорозміриКомірок_Object ДовідникОбєкт, ТипорозміриКомірок_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ТипорозміриКомірок_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ТипорозміриКомірок_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ТипорозміриКомірок_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ТипорозміриКомірок_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
