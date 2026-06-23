

/*
        СписанняНематеріальнихАктивів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняНематеріальнихАктивів_Triggers
{
    public static async Task New(СписанняНематеріальнихАктивів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняНематеріальнихАктивів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняНематеріальнихАктивів(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняНематеріальнихАктивів_Object ДокументОбєкт, СписанняНематеріальнихАктивів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняНематеріальнихАктивів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняНематеріальнихАктивів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняНематеріальнихАктивів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняНематеріальнихАктивів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняНематеріальнихАктивів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    