

/*
        МалоцінніПредмети_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class МалоцінніПредмети_Triggers
{
    public static async Task New(МалоцінніПредмети_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.МалоцінніПредмети();
        ДовідникОбєкт.Код = (await НумераціяДовідників.МалоцінніПредмети(++number)).ToString("D6");
    }

    public static Task Copying(МалоцінніПредмети_Object ДовідникОбєкт, МалоцінніПредмети_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(МалоцінніПредмети_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(МалоцінніПредмети_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(МалоцінніПредмети_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(МалоцінніПредмети_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
