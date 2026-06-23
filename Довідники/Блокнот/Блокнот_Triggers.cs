
/*
    Блокнот_Triggers.cs
    Тригери для довідника Блокнот
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Блокнот_Triggers
{
    public static async Task New(Блокнот_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Блокнот();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Блокнот(++number)).ToString("D6");

        ДовідникОбєкт.ДатаЗапису = DateTime.Now;
    }

    public static Task Copying(Блокнот_Object ДовідникОбєкт, Блокнот_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Блокнот_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Блокнот_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Блокнот_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Блокнот_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
