

/*
        ТипиБухОперацій_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ТипиБухОперацій_Triggers
{
    public static Task New(ТипиБухОперацій_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ТипиБухОперацій_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(ТипиБухОперацій_Objest ДовідникОбєкт, ТипиБухОперацій_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ТипиБухОперацій_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ТипиБухОперацій_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ТипиБухОперацій_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ТипиБухОперацій_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
