
/*
    ДоговориКонтрагентів_Triggers.cs
    Тригери для довідника ДоговориКонтрагентів
*/

using GeneratedCode.Константи;
using GeneratedCode.Перелічення;

namespace GeneratedCode.Довідники;

class ДоговориКонтрагентів_Triggers
{
    public static async Task New(ДоговориКонтрагентів_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ДоговориКонтрагентів();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ДоговориКонтрагентів(++number)).ToString("D6");
    }

    public static Task Copying(ДоговориКонтрагентів_Object ДовідникОбєкт, ДоговориКонтрагентів_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ДоговориКонтрагентів_Object ДовідникОбєкт)
    {
        ДовідникОбєкт.ТипДоговоруПредставлення = ПсевдонімиПерелічення.ТипДоговорів_Alias(ДовідникОбєкт.ТипДоговору);
        return Task.CompletedTask;
    }

    public static Task AfterSave(ДоговориКонтрагентів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ДоговориКонтрагентів_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ДоговориКонтрагентів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
