
/*
    Файли_Triggers.cs
    Тригери для довідника Файли
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Файли_Triggers
{
    public static async Task New(Файли_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Файли();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Файли(++number)).ToString("D6");
    }

    public static Task Copying(Файли_Object ДовідникОбєкт, Файли_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Файли_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Файли_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Файли_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Файли_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
