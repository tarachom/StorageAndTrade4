

/*
        ОсновніЗасоби_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

static class ОсновніЗасоби_Triggers
{
    public static Task New(ОсновніЗасоби_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ОсновніЗасоби_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(ОсновніЗасоби_Objest ДовідникОбєкт, ОсновніЗасоби_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ОсновніЗасоби_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ОсновніЗасоби_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ОсновніЗасоби_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ОсновніЗасоби_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
