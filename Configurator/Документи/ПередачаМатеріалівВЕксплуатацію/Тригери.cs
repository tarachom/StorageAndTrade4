

/*
        ПередачаМатеріалівВЕксплуатацію_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПередачаМатеріалівВЕксплуатацію_Triggers
{
    public static async Task New(ПередачаМатеріалівВЕксплуатацію_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПередачаМатеріалівВЕксплуатацію();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПередачаМатеріалівВЕксплуатацію(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПередачаМатеріалівВЕксплуатацію_Object ДокументОбєкт, ПередачаМатеріалівВЕксплуатацію_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПередачаМатеріалівВЕксплуатацію_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПередачаМатеріалівВЕксплуатацію_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПередачаМатеріалівВЕксплуатацію_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПередачаМатеріалівВЕксплуатацію_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПередачаМатеріалівВЕксплуатацію_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    