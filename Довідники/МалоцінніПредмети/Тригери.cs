

/*
        МалоцінніПредмети_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class МалоцінніПредмети_Triggers
{
    public static Task New(МалоцінніПредмети_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.МалоцінніПредмети_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(МалоцінніПредмети_Objest ДовідникОбєкт, МалоцінніПредмети_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(МалоцінніПредмети_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(МалоцінніПредмети_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(МалоцінніПредмети_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(МалоцінніПредмети_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
