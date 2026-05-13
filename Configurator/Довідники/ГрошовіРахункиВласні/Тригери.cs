

/*
        ГрошовіРахункиВласні_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ГрошовіРахункиВласні_Triggers
{
    public static async ValueTask New(ГрошовіРахункиВласні_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ГрошовіРахункиВласні_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(ГрошовіРахункиВласні_Objest ДовідникОбєкт, ГрошовіРахункиВласні_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(ГрошовіРахункиВласні_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(ГрошовіРахункиВласні_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(ГрошовіРахункиВласні_Objest ДовідникОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(ГрошовіРахункиВласні_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    