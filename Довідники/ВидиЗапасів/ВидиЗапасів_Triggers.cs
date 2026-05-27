
/*
    ВидиЗапасів_Triggers.cs
    Тригери для довідника ВидиЗапасів
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ВидиЗапасів_Triggers
{
    public static Task New(ВидиЗапасів_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ВидиЗапасів_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(ВидиЗапасів_Objest ДовідникОбєкт, ВидиЗапасів_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиЗапасів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиЗапасів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиЗапасів_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиЗапасів_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}