
/*
    ВидиНоменклатури_Triggers.cs
    Тригери для довідника ВидиНоменклатури
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ВидиНоменклатури_Triggers
{
    public static async Task New(ВидиНоменклатури_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ВидиНоменклатури();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ВидиНоменклатури(++number)).ToString("D6");
    }

    public static Task Copying(ВидиНоменклатури_Object ДовідникОбєкт, ВидиНоменклатури_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиНоменклатури_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиНоменклатури_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиНоменклатури_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиНоменклатури_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
