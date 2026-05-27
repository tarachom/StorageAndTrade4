
/*
    СтруктураПідприємства_Triggers.cs
    Тригери для довідника СтруктураПідприємства
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class СтруктураПідприємства_Triggers
{
    public static Task New(СтруктураПідприємства_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.СтруктураПідприємства_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(СтруктураПідприємства_Objest ДовідникОбєкт, СтруктураПідприємства_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СтруктураПідприємства_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(СтруктураПідприємства_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СтруктураПідприємства_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СтруктураПідприємства_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
