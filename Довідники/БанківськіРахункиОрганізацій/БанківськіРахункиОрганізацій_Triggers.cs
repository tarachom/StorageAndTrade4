
/*
    БанківськіРахункиОрганізацій_Triggers.cs
    Тригери для довідника БанківськіРахункиОрганізацій
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class БанківськіРахункиОрганізацій_Triggers
{
    public static async Task New(БанківськіРахункиОрганізацій_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.БанківськіРахункиОрганізацій();
        ДовідникОбєкт.Код = (await НумераціяДовідників.БанківськіРахункиОрганізацій(++number)).ToString("D6");
    }

    public static Task Copying(БанківськіРахункиОрганізацій_Object ДовідникОбєкт, БанківськіРахункиОрганізацій_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(БанківськіРахункиОрганізацій_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(БанківськіРахункиОрганізацій_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(БанківськіРахункиОрганізацій_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(БанківськіРахункиОрганізацій_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
