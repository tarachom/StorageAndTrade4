

/*
        СписанняОсновнихЗасобів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняОсновнихЗасобів_Triggers
{
    public static async Task New(СписанняОсновнихЗасобів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняОсновнихЗасобів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняОсновнихЗасобів(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняОсновнихЗасобів_Object ДокументОбєкт, СписанняОсновнихЗасобів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняОсновнихЗасобів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняОсновнихЗасобів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняОсновнихЗасобів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняОсновнихЗасобів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняОсновнихЗасобів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    