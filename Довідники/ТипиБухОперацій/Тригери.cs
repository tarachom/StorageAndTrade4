

/*
        ТипиБухОперацій_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ТипиБухОперацій_Triggers
{
    public static async ValueTask New(ТипиБухОперацій_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ТипиБухОперацій_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(ТипиБухОперацій_Objest ДовідникОбєкт, ТипиБухОперацій_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(ТипиБухОперацій_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(ТипиБухОперацій_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(ТипиБухОперацій_Objest ДовідникОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(ТипиБухОперацій_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    