
/*
    Організації_Triggers.cs
    Тригери для довідника Організації
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Організації_Triggers
{
    public static async Task New(Організації_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Організації();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Організації(++number)).ToString("D6");
    }

    public static Task Copying(Організації_Objest ДовідникОбєкт, Організації_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Організації_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Організації_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Організації_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Організації_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}