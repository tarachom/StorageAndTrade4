

/*
        ПереміщенняОсновнихЗасобів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПереміщенняОсновнихЗасобів_Triggers
{
    public static async Task New(ПереміщенняОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПереміщенняОсновнихЗасобів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПереміщенняОсновнихЗасобів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПереміщенняОсновнихЗасобів_Objest ДокументОбєкт, ПереміщенняОсновнихЗасобів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереміщенняОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереміщенняОсновнихЗасобів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереміщенняОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереміщенняОсновнихЗасобів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереміщенняОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    