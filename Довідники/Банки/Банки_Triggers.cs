
/*
    Банки_Triggers.cs
    Тригери для довідника Банки
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Банки_Triggers
{
    public static Task New(Банки_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Банки_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(Банки_Objest ДовідникОбєкт, Банки_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Банки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Банки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Банки_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Банки_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}