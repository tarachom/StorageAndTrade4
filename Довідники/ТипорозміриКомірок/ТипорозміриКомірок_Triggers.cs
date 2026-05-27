
/*
    ТипорозміриКомірок_Triggers.cs
    Тригери для довідника ТипорозміриКомірок
*/

namespace GeneratedCode.Довідники;

class ТипорозміриКомірок_Triggers
{
    public static Task New(ТипорозміриКомірок_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task Copying(ТипорозміриКомірок_Objest ДовідникОбєкт, ТипорозміриКомірок_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ТипорозміриКомірок_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ТипорозміриКомірок_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ТипорозміриКомірок_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ТипорозміриКомірок_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
