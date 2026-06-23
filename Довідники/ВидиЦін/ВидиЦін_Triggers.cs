
/*
    ВидиЦін_Triggers.cs
    Тригери для довідника ВидиЦін
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class ВидиЦін_Triggers
{
    public static async Task New(ВидиЦін_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ВидиЦін();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ВидиЦін(++number)).ToString("D6");
    }

    public static Task Copying(ВидиЦін_Object ДовідникОбєкт, ВидиЦін_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВидиЦін_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВидиЦін_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВидиЦін_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВидиЦін_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
