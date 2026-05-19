

/*
        НоменклатураВнутрішня_Папки_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class НоменклатураВнутрішня_Папки_Triggers
{
    public static async ValueTask New(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.НоменклатураВнутрішня_Папки_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт, НоменклатураВнутрішня_Папки_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(НоменклатураВнутрішня_Папки_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    