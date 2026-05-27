

/*
        ВидиПодатків_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

static class ВидиПодатків_Triggers
{
    public static Task New(ВидиПодатків_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ВидиПодатків_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(ВидиПодатків_Objest ДовідникОбєкт, ВидиПодатків_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиПодатків_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиПодатків_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиПодатків_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиПодатків_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
