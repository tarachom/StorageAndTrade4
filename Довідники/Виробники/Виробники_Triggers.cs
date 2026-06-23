
/*
    Виробники_Triggers.cs
    Тригери для довідника Виробники
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Виробники_Triggers
{
    public static async Task New(Виробники_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Виробники();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Виробники(++number)).ToString("D6");
    }

    public static Task Copying(Виробники_Object ДовідникОбєкт, Виробники_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Виробники_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Виробники_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Виробники_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Виробники_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
