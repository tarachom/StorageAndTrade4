
/*
    ВидиНоменклатури_Triggers.cs
    Тригери для довідника ВидиНоменклатури
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ВидиНоменклатури_Triggers
{
    public static async Task New(ВидиНоменклатури_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ВидиНоменклатури();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ВидиНоменклатури(++number)).ToString("D6");
    }

    public static Task Copying(ВидиНоменклатури_Objest ДовідникОбєкт, ВидиНоменклатури_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиНоменклатури_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
