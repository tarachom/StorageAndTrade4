
/*
    ДоговориКонтрагентів_Triggers.cs
    Тригери для довідника ДоговориКонтрагентів
*/

using GeneratedCode.Константи;
using GeneratedCode.Перелічення;

namespace GeneratedCode.Довідники;

class ДоговориКонтрагентів_Triggers
{
    public static async Task New(ДоговориКонтрагентів_Objest ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ДоговориКонтрагентів();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ДоговориКонтрагентів(++number)).ToString("D6");
    }

    public static Task Copying(ДоговориКонтрагентів_Objest ДовідникОбєкт, ДоговориКонтрагентів_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ДоговориКонтрагентів_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.ТипДоговоруПредставлення = ПсевдонімиПерелічення.ТипДоговорів_Alias(ДовідникОбєкт.ТипДоговору);
        return Task.CompletedTask;
    }

    public static Task AfterSave(ДоговориКонтрагентів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ДоговориКонтрагентів_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ДоговориКонтрагентів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
