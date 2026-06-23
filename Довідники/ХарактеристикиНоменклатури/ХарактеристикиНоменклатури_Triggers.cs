
/*
    ХарактеристикиНоменклатури_Triggers.cs
    Тригери для довідника ХарактеристикиНоменклатури
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ХарактеристикиНоменклатури_Triggers
{
    public static async Task New(ХарактеристикиНоменклатури_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ХарактеристикиНоменклатури();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ХарактеристикиНоменклатури(++number)).ToString("D6");
    }

    public static Task Copying(ХарактеристикиНоменклатури_Object ДовідникОбєкт, ХарактеристикиНоменклатури_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ХарактеристикиНоменклатури_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ХарактеристикиНоменклатури_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ХарактеристикиНоменклатури_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ХарактеристикиНоменклатури_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
