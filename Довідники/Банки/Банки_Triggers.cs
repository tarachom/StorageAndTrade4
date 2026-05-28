
/*
    Банки_Triggers.cs
    Тригери для довідника Банки
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Банки_Triggers
{
    public static async Task New(Банки_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Банки();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Банки(++number)).ToString("D6");
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