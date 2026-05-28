

/*
        ПереоцінкаОсновнихЗасобів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПереоцінкаОсновнихЗасобів_Triggers
{
    public static async Task New(ПереоцінкаОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПереоцінкаОсновнихЗасобів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПереоцінкаОсновнихЗасобів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПереоцінкаОсновнихЗасобів_Objest ДокументОбєкт, ПереоцінкаОсновнихЗасобів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереоцінкаОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереоцінкаОсновнихЗасобів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереоцінкаОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереоцінкаОсновнихЗасобів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереоцінкаОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    