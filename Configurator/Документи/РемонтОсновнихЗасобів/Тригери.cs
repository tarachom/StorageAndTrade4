

/*
        РемонтОсновнихЗасобів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class РемонтОсновнихЗасобів_Triggers
{
    public static async Task New(РемонтОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.РемонтОсновнихЗасобів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.РемонтОсновнихЗасобів(++number)).ToString("D8");
                    
    }

    public static Task Copying(РемонтОсновнихЗасобів_Objest ДокументОбєкт, РемонтОсновнихЗасобів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РемонтОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РемонтОсновнихЗасобів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РемонтОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РемонтОсновнихЗасобів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РемонтОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    