

/*
        ПередачаНематеріальнихАктивів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПередачаНематеріальнихАктивів_Triggers
{
    public static async Task New(ПередачаНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПередачаНематеріальнихАктивів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПередачаНематеріальнихАктивів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПередачаНематеріальнихАктивів_Objest ДокументОбєкт, ПередачаНематеріальнихАктивів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПередачаНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПередачаНематеріальнихАктивів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПередачаНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПередачаНематеріальнихАктивів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПередачаНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    