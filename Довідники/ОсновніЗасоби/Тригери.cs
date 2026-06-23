

/*
        ОсновніЗасоби_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

static class ОсновніЗасоби_Triggers
{
    public static async Task New(ОсновніЗасоби_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ОсновніЗасоби();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ОсновніЗасоби(++number)).ToString("D6");
    }

    public static Task Copying(ОсновніЗасоби_Object ДовідникОбєкт, ОсновніЗасоби_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ОсновніЗасоби_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ОсновніЗасоби_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ОсновніЗасоби_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ОсновніЗасоби_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
