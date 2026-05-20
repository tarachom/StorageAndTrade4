

/*
        Співробітники_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class Співробітники_Triggers
{
    public static async ValueTask New(Співробітники_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Співробітники_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(Співробітники_Objest ДовідникОбєкт, Співробітники_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(Співробітники_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(Співробітники_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(Співробітники_Objest ДовідникОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(Співробітники_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    