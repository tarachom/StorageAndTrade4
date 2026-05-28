
/*
    ХарактеристикиНоменклатури_Triggers.cs
    Тригери для довідника ХарактеристикиНоменклатури
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ХарактеристикиНоменклатури_Triggers
{
    public static async Task New(ХарактеристикиНоменклатури_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ХарактеристикиНоменклатури();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ХарактеристикиНоменклатури(++number)).ToString("D6");
    }

    public static Task Copying(ХарактеристикиНоменклатури_Objest ДовідникОбєкт, ХарактеристикиНоменклатури_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ХарактеристикиНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ХарактеристикиНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ХарактеристикиНоменклатури_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ХарактеристикиНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
