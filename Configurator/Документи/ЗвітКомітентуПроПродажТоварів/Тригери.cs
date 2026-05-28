

/*
        ЗвітКомітентуПроПродажТоварів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ЗвітКомітентуПроПродажТоварів_Triggers
{
    public static async Task New(ЗвітКомітентуПроПродажТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ЗвітКомітентуПроПродажТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗвітКомітентуПроПродажТоварів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ЗвітКомітентуПроПродажТоварів_Objest ДокументОбєкт, ЗвітКомітентуПроПродажТоварів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗвітКомітентуПроПродажТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗвітКомітентуПроПродажТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗвітКомітентуПроПродажТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗвітКомітентуПроПродажТоварів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗвітКомітентуПроПродажТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    