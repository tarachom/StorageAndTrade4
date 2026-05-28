

/*
        ПереміщенняНематеріальнихАктивів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПереміщенняНематеріальнихАктивів_Triggers
{
    public static async Task New(ПереміщенняНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПереміщенняНематеріальнихАктивів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПереміщенняНематеріальнихАктивів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПереміщенняНематеріальнихАктивів_Objest ДокументОбєкт, ПереміщенняНематеріальнихАктивів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереміщенняНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереміщенняНематеріальнихАктивів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереміщенняНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереміщенняНематеріальнихАктивів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереміщенняНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    