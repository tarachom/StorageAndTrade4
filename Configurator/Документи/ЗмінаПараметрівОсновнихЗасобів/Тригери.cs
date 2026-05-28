

/*
        ЗмінаПараметрівОсновнихЗасобів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ЗмінаПараметрівОсновнихЗасобів_Triggers
{
    public static async Task New(ЗмінаПараметрівОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ЗмінаПараметрівОсновнихЗасобів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗмінаПараметрівОсновнихЗасобів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ЗмінаПараметрівОсновнихЗасобів_Objest ДокументОбєкт, ЗмінаПараметрівОсновнихЗасобів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗмінаПараметрівОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗмінаПараметрівОсновнихЗасобів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗмінаПараметрівОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗмінаПараметрівОсновнихЗасобів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗмінаПараметрівОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    