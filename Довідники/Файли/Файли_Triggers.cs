
/*
    Файли_Triggers.cs
    Тригери для довідника Файли
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Файли_Triggers
{
    public static async Task New(Файли_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Файли();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Файли(++number)).ToString("D6");
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
