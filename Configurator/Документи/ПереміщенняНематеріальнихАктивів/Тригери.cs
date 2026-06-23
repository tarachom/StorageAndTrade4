

/*
        ПереміщенняНематеріальнихАктивів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПереміщенняНематеріальнихАктивів_Triggers
{
    public static async Task New(ПереміщенняНематеріальнихАктивів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПереміщенняНематеріальнихАктивів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПереміщенняНематеріальнихАктивів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПереміщенняНематеріальнихАктивів_Object ДокументОбєкт, ПереміщенняНематеріальнихАктивів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереміщенняНематеріальнихАктивів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереміщенняНематеріальнихАктивів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереміщенняНематеріальнихАктивів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереміщенняНематеріальнихАктивів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереміщенняНематеріальнихАктивів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    