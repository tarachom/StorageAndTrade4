

/*
        ЗвітКомісіонераПроПродажТоварів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ЗвітКомісіонераПроПродажТоварів_Triggers
{
    public static async Task New(ЗвітКомісіонераПроПродажТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ЗвітКомісіонераПроПродажТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗвітКомісіонераПроПродажТоварів(++number)).ToString("D8");
                    
    }

    public static Task Copying(ЗвітКомісіонераПроПродажТоварів_Objest ДокументОбєкт, ЗвітКомісіонераПроПродажТоварів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗвітКомісіонераПроПродажТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗвітКомісіонераПроПродажТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗвітКомісіонераПроПродажТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗвітКомісіонераПроПродажТоварів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗвітКомісіонераПроПродажТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    