

/*
        ПередачаОсновнихЗасобів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПередачаОсновнихЗасобів_Triggers
{
    public static async Task New(ПередачаОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПередачаОсновнихЗасобів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПередачаОсновнихЗасобів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПередачаОсновнихЗасобів_Objest ДокументОбєкт, ПередачаОсновнихЗасобів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПередачаОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПередачаОсновнихЗасобів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПередачаОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПередачаОсновнихЗасобів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПередачаОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    