

/*
        МалоцінніПредмети_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class МалоцінніПредмети_Triggers
{
    public static async ValueTask New(МалоцінніПредмети_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.МалоцінніПредмети_Const).ToString("D6");
        await ValueTask.FromResult(true);
    }

    public static async ValueTask Copying(МалоцінніПредмети_Objest ДовідникОбєкт, МалоцінніПредмети_Objest Основа)
    {
        
        ДовідникОбєкт.Назва += " - Копія";
        
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeSave(МалоцінніПредмети_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask AfterSave(МалоцінніПредмети_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask SetDeletionLabel(МалоцінніПредмети_Objest ДовідникОбєкт, bool label)
    {
        await ValueTask.FromResult(true);
    }

    public static async ValueTask BeforeDelete(МалоцінніПредмети_Objest ДовідникОбєкт)
    {
        await ValueTask.FromResult(true);
    }
}
    