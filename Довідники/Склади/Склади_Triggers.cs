
/*
    Склади_Triggers.cs
    Тригери для довідника Склади
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Склади_Triggers
{
    public static async Task New(Склади_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Склади();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Склади(++number)).ToString("D6");
    }

    public static Task Copying(Склади_Object ДовідникОбєкт, Склади_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Склади_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Склади_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Склади_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Склади_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
