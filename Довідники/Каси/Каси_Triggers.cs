
/*
    Каси_Triggers.cs
    Тригери для довідника Каси
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Каси_Triggers
{
    public static async Task New(Каси_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Каси();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Каси(++number)).ToString("D6");
    }

    public static Task Copying(Каси_Objest ДовідникОбєкт, Каси_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Каси_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Каси_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Каси_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Каси_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
