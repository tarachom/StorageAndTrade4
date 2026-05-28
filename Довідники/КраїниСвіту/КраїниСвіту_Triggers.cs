
/*
    КраїниСвіту_Triggers.cs
    Тригери для довідника КраїниСвіту
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class КраїниСвіту_Triggers
{
    public static async Task New(КраїниСвіту_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.КраїниСвіту();
        ДовідникОбєкт.Код = (await НумераціяДовідників.КраїниСвіту(++number)).ToString("D6");
    }

    public static Task Copying(КраїниСвіту_Objest ДовідникОбєкт, КраїниСвіту_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(КраїниСвіту_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(КраїниСвіту_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(КраїниСвіту_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(КраїниСвіту_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
