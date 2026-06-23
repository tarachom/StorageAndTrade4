

/*
        РемонтОсновнихЗасобів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class РемонтОсновнихЗасобів_Triggers
{
    public static async Task New(РемонтОсновнихЗасобів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.РемонтОсновнихЗасобів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.РемонтОсновнихЗасобів(++number)).ToString("D8");
                    
    }

    public static Task Copying(РемонтОсновнихЗасобів_Object ДокументОбєкт, РемонтОсновнихЗасобів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РемонтОсновнихЗасобів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РемонтОсновнихЗасобів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РемонтОсновнихЗасобів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РемонтОсновнихЗасобів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РемонтОсновнихЗасобів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    