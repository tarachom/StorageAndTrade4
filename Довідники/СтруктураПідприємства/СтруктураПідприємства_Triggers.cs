
/*
    СтруктураПідприємства_Triggers.cs
    Тригери для довідника СтруктураПідприємства
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class СтруктураПідприємства_Triggers
{
    public static async Task New(СтруктураПідприємства_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.СтруктураПідприємства();
        ДовідникОбєкт.Код = (await НумераціяДовідників.СтруктураПідприємства(++number)).ToString("D6");
    }

    public static Task Copying(СтруктураПідприємства_Object ДовідникОбєкт, СтруктураПідприємства_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СтруктураПідприємства_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(СтруктураПідприємства_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СтруктураПідприємства_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СтруктураПідприємства_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
