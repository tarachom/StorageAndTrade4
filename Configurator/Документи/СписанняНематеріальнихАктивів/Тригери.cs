

/*
        СписанняНематеріальнихАктивів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняНематеріальнихАктивів_Triggers
{
    public static async Task New(СписанняНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняНематеріальнихАктивів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняНематеріальнихАктивів(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняНематеріальнихАктивів_Objest ДокументОбєкт, СписанняНематеріальнихАктивів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняНематеріальнихАктивів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняНематеріальнихАктивів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    