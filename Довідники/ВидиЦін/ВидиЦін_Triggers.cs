
/*
    ВидиЦін_Triggers.cs
    Тригери для довідника ВидиЦін
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ВидиЦін_Triggers
{
    public static Task New(ВидиЦін_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ВидиЦін_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(ВидиЦін_Objest ДовідникОбєкт, ВидиЦін_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиЦін_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиЦін_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиЦін_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиЦін_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
