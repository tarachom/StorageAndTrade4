
/*
    Файли_Triggers.cs
    Тригери для довідника Файли
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Файли_Triggers
{
    public static Task New(Файли_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Файли_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(Файли_Objest ДовідникОбєкт, Файли_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Файли_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Файли_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Файли_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Файли_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
