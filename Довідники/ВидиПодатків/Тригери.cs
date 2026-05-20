

/*
        ВидиПодатків_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class ВидиПодатків_Triggers
{
    public static async ValueTask New(ВидиПодатків_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ВидиПодатків_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(ВидиПодатків_Objest ДовідникОбєкт, ВидиПодатків_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(ВидиПодатків_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(ВидиПодатків_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(ВидиПодатків_Objest ДовідникОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(ВидиПодатків_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    