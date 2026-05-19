

/*
        НоменклатураВнутрішня_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class НоменклатураВнутрішня_Triggers
{
    public static async ValueTask New(НоменклатураВнутрішня_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.НоменклатураВнутрішня_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(НоменклатураВнутрішня_Objest ДовідникОбєкт, НоменклатураВнутрішня_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(НоменклатураВнутрішня_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(НоменклатураВнутрішня_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(НоменклатураВнутрішня_Objest ДовідникОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(НоменклатураВнутрішня_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    