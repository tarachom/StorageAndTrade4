

/*
        КласифікаторОдиницьВиміру_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class КласифікаторОдиницьВиміру_Triggers
{
    public static async Task New(КласифікаторОдиницьВиміру_Object ДовідникОбєкт)
    {
        
        int number = await НумераціяДовідників.КласифікаторОдиницьВиміру();
        ДовідникОбєкт.Код = (await НумераціяДовідників.КласифікаторОдиницьВиміру(++number)).ToString("D4");
              
    }

    public static Task Copying(КласифікаторОдиницьВиміру_Object ДовідникОбєкт, КласифікаторОдиницьВиміру_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(КласифікаторОдиницьВиміру_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(КласифікаторОдиницьВиміру_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(КласифікаторОдиницьВиміру_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(КласифікаторОдиницьВиміру_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
    