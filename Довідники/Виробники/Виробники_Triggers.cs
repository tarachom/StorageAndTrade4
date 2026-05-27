
/*
    Виробники_Triggers.cs
    Тригери для довідника Виробники
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Виробники_Triggers
{
    public static Task New(Виробники_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Виробники_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(Виробники_Objest ДовідникОбєкт, Виробники_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Виробники_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Виробники_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Виробники_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Виробники_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
