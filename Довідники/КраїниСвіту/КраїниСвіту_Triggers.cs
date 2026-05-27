
/*
    КраїниСвіту_Triggers.cs
    Тригери для довідника КраїниСвіту
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class КраїниСвіту_Triggers
{
    public static Task New(КраїниСвіту_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.КраїниСвіту_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(КраїниСвіту_Objest ДовідникОбєкт, КраїниСвіту_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(КраїниСвіту_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(КраїниСвіту_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(КраїниСвіту_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(КраїниСвіту_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
