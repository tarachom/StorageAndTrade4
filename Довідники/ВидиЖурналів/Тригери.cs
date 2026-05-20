

/*
        ВидиЖурналів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ВидиЖурналів_Triggers
{
    public static async ValueTask New(ВидиЖурналів_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ВидиЖурналів_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(ВидиЖурналів_Objest ДовідникОбєкт, ВидиЖурналів_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(ВидиЖурналів_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(ВидиЖурналів_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(ВидиЖурналів_Objest ДовідникОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(ВидиЖурналів_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    