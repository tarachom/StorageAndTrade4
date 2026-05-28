

/*
        ПередачаМатеріалівВЕксплуатацію_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПередачаМатеріалівВЕксплуатацію_Triggers
{
    public static async Task New(ПередачаМатеріалівВЕксплуатацію_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПередачаМатеріалівВЕксплуатацію();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПередачаМатеріалівВЕксплуатацію(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПередачаМатеріалівВЕксплуатацію_Objest ДокументОбєкт, ПередачаМатеріалівВЕксплуатацію_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПередачаМатеріалівВЕксплуатацію_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПередачаМатеріалівВЕксплуатацію_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПередачаМатеріалівВЕксплуатацію_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПередачаМатеріалівВЕксплуатацію_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПередачаМатеріалівВЕксплуатацію_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    