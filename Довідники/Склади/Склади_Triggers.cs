
/*
    Склади_Triggers.cs
    Тригери для довідника Склади
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Склади_Triggers
{
    public static async Task New(Склади_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Склади();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Склади(++number)).ToString("D6");
    }

    public static Task Copying(Склади_Objest ДовідникОбєкт, Склади_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Склади_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Склади_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Склади_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Склади_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
