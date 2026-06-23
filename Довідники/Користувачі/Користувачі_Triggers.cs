
/*
    Користувачі_Triggers.cs
    Тригери для довідника Користувачі
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Користувачі_Triggers
{
    public static async Task New(Користувачі_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Користувачі();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Користувачі(++number)).ToString("D6");
    }

    public static Task Copying(Користувачі_Object ДовідникОбєкт, Користувачі_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Користувачі_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Користувачі_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Користувачі_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Користувачі_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}