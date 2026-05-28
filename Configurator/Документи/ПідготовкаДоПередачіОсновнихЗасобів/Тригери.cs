

/*
        ПідготовкаДоПередачіОсновнихЗасобів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПідготовкаДоПередачіОсновнихЗасобів_Triggers
{
    public static async Task New(ПідготовкаДоПередачіОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПідготовкаДоПередачіОсновнихЗасобів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПідготовкаДоПередачіОсновнихЗасобів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПідготовкаДоПередачіОсновнихЗасобів_Objest ДокументОбєкт, ПідготовкаДоПередачіОсновнихЗасобів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПідготовкаДоПередачіОсновнихЗасобів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПідготовкаДоПередачіОсновнихЗасобів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПідготовкаДоПередачіОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПідготовкаДоПередачіОсновнихЗасобів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПідготовкаДоПередачіОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    