

/*
        ПереміщенняОсновнихЗасобів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПереміщенняОсновнихЗасобів_Triggers
{
    public static async Task New(ПереміщенняОсновнихЗасобів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПереміщенняОсновнихЗасобів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПереміщенняОсновнихЗасобів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПереміщенняОсновнихЗасобів_Object ДокументОбєкт, ПереміщенняОсновнихЗасобів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереміщенняОсновнихЗасобів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереміщенняОсновнихЗасобів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереміщенняОсновнихЗасобів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереміщенняОсновнихЗасобів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереміщенняОсновнихЗасобів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    