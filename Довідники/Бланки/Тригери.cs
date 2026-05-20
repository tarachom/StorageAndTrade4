

/*
        Бланки_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class Бланки_Triggers
{
    public static async ValueTask New(Бланки_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Бланки_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(Бланки_Objest ДовідникОбєкт, Бланки_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(Бланки_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(Бланки_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(Бланки_Objest ДовідникОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(Бланки_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    