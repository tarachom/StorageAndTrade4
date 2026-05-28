
/*
    Виробники_Triggers.cs
    Тригери для довідника Виробники
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Виробники_Triggers
{
    public static async Task New(Виробники_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Виробники();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Виробники(++number)).ToString("D6");
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
