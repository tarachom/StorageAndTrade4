
/*
    ВидиНоменклатури_Triggers.cs
    Тригери для довідника ВидиНоменклатури
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ВидиНоменклатури_Triggers
{
    public static Task New(ВидиНоменклатури_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ВидиНоменклатури_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(ВидиНоменклатури_Objest ДовідникОбєкт, ВидиНоменклатури_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиНоменклатури_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
