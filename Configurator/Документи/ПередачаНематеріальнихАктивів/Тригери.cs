

/*
        ПередачаНематеріальнихАктивів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПередачаНематеріальнихАктивів_Triggers
{
    public static async Task New(ПередачаНематеріальнихАктивів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПередачаНематеріальнихАктивів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПередачаНематеріальнихАктивів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПередачаНематеріальнихАктивів_Object ДокументОбєкт, ПередачаНематеріальнихАктивів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПередачаНематеріальнихАктивів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПередачаНематеріальнихАктивів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПередачаНематеріальнихАктивів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПередачаНематеріальнихАктивів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПередачаНематеріальнихАктивів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    