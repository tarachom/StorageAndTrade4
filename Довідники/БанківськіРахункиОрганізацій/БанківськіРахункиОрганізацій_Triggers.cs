
/*
    БанківськіРахункиОрганізацій_Triggers.cs
    Тригери для довідника БанківськіРахункиОрганізацій
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class БанківськіРахункиОрганізацій_Triggers
{
    public static Task New(БанківськіРахункиОрганізацій_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.БанківськіРахункиОрганізацій_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(БанківськіРахункиОрганізацій_Objest ДовідникОбєкт, БанківськіРахункиОрганізацій_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(БанківськіРахункиОрганізацій_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(БанківськіРахункиОрганізацій_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(БанківськіРахункиОрганізацій_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(БанківськіРахункиОрганізацій_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
