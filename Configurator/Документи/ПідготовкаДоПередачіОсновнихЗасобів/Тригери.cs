

/*
        ПідготовкаДоПередачіОсновнихЗасобів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПідготовкаДоПередачіОсновнихЗасобів_Triggers
{
    public static async Task New(ПідготовкаДоПередачіОсновнихЗасобів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПідготовкаДоПередачіОсновнихЗасобів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПідготовкаДоПередачіОсновнихЗасобів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПідготовкаДоПередачіОсновнихЗасобів_Object ДокументОбєкт, ПідготовкаДоПередачіОсновнихЗасобів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПідготовкаДоПередачіОсновнихЗасобів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПідготовкаДоПередачіОсновнихЗасобів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПідготовкаДоПередачіОсновнихЗасобів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПідготовкаДоПередачіОсновнихЗасобів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПідготовкаДоПередачіОсновнихЗасобів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    