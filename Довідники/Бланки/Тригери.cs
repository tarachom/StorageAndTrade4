

/*
        Бланки_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class Бланки_Triggers
{
    public static Task New(Бланки_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Бланки_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(Бланки_Objest ДовідникОбєкт, Бланки_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Бланки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Бланки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Бланки_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Бланки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
