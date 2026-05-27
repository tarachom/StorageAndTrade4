
/*
    Користувачі_Triggers.cs
    Тригери для довідника Користувачі
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Користувачі_Triggers
{
    public static Task New(Користувачі_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Користувачі_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(Користувачі_Objest ДовідникОбєкт, Користувачі_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Користувачі_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Користувачі_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Користувачі_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Користувачі_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}