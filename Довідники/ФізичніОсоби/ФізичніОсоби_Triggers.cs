
/*
    ФізичніОсоби_Triggers.cs
    Тригери для довідника ФізичніОсоби
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ФізичніОсоби_Triggers
{
    public static async Task New(ФізичніОсоби_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ФізичніОсоби();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ФізичніОсоби(++number)).ToString("D6");
    }

    public static Task Copying(ФізичніОсоби_Objest ДовідникОбєкт, ФізичніОсоби_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ФізичніОсоби_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ФізичніОсоби_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ФізичніОсоби_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ФізичніОсоби_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
