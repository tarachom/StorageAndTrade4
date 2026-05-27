
/*
    Склади_Triggers.cs
    Тригери для довідника Склади
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Склади_Triggers
{
    public static Task New(Склади_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Склади_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(Склади_Objest ДовідникОбєкт, Склади_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Склади_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Склади_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Склади_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Склади_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
