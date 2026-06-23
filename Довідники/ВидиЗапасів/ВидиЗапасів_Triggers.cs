
/*
    ВидиЗапасів_Triggers.cs
    Тригери для довідника ВидиЗапасів
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ВидиЗапасів_Triggers
{
    public static async Task New(ВидиЗапасів_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ВидиЗапасів();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ВидиЗапасів(++number)).ToString("D6");
    }

    public static Task Copying(ВидиЗапасів_Object ДовідникОбєкт, ВидиЗапасів_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиЗапасів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиЗапасів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиЗапасів_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиЗапасів_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}