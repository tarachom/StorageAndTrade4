

/*
        ЗвітКомітентуПроПродажТоварів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ЗвітКомітентуПроПродажТоварів_Triggers
{
    public static async Task New(ЗвітКомітентуПроПродажТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ЗвітКомітентуПроПродажТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗвітКомітентуПроПродажТоварів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ЗвітКомітентуПроПродажТоварів_Object ДокументОбєкт, ЗвітКомітентуПроПродажТоварів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗвітКомітентуПроПродажТоварів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗвітКомітентуПроПродажТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗвітКомітентуПроПродажТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗвітКомітентуПроПродажТоварів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗвітКомітентуПроПродажТоварів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    