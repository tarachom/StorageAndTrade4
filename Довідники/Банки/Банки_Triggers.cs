
/*
    Банки_Triggers.cs
    Тригери для довідника Банки
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Банки_Triggers
{
    public static async Task New(Банки_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Банки();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Банки(++number)).ToString("D6");
    }

    public static Task Copying(Банки_Object ДовідникОбєкт, Банки_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Банки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Банки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Банки_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Банки_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}