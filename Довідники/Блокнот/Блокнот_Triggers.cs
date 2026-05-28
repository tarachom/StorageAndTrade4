
/*
    Блокнот_Triggers.cs
    Тригери для довідника Блокнот
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Блокнот_Triggers
{
    public static async Task New(Блокнот_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Блокнот();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Блокнот(++number)).ToString("D6");

        ДовідникОбєкт.ДатаЗапису = DateTime.Now;
    }

    public static Task Copying(Блокнот_Objest ДовідникОбєкт, Блокнот_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Блокнот_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Блокнот_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Блокнот_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Блокнот_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
