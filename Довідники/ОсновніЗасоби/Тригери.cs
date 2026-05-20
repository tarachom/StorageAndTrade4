

/*
        ОсновніЗасоби_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ОсновніЗасоби_Triggers
{
    public static async ValueTask New(ОсновніЗасоби_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ОсновніЗасоби_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(ОсновніЗасоби_Objest ДовідникОбєкт, ОсновніЗасоби_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(ОсновніЗасоби_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(ОсновніЗасоби_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(ОсновніЗасоби_Objest ДовідникОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(ОсновніЗасоби_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    