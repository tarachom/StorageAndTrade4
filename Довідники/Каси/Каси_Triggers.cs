
/*
    Каси_Triggers.cs
    Тригери для довідника Каси
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Каси_Triggers
{
    public static async Task New(Каси_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Каси();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Каси(++number)).ToString("D6");
    }

    public static Task Copying(Каси_Object ДовідникОбєкт, Каси_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Каси_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Каси_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Каси_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Каси_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
