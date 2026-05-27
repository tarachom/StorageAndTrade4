

/*
        ВидиЖурналів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ВидиЖурналів_Triggers
{
    public static Task New(ВидиЖурналів_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ВидиЖурналів_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(ВидиЖурналів_Objest ДовідникОбєкт, ВидиЖурналів_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиЖурналів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиЖурналів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиЖурналів_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиЖурналів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
