
/*
    ПакуванняОдиниціВиміру_Triggers.cs
    Тригери для довідника ПакуванняОдиниціВиміру
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ПакуванняОдиниціВиміру_Triggers
{
    public static Task New(ПакуванняОдиниціВиміру_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ПакуванняОдиниціВиміру_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(ПакуванняОдиниціВиміру_Objest ДовідникОбєкт, ПакуванняОдиниціВиміру_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПакуванняОдиниціВиміру_Objest ДовідникОбєкт)
    {
        if (ДовідникОбєкт.КількістьУпаковок <= 0) ДовідникОбєкт.КількістьУпаковок = 1;
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПакуванняОдиниціВиміру_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПакуванняОдиниціВиміру_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПакуванняОдиниціВиміру_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
