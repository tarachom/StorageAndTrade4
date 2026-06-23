

/*
        ПереміщенняМатеріалівВЕксплуатації_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПереміщенняМатеріалівВЕксплуатації_Triggers
{
    public static  Task New(ПереміщенняМатеріалівВЕксплуатації_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        return Task.CompletedTask;
                    
    }

    public static Task Copying(ПереміщенняМатеріалівВЕксплуатації_Object ДокументОбєкт, ПереміщенняМатеріалівВЕксплуатації_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереміщенняМатеріалівВЕксплуатації_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереміщенняМатеріалівВЕксплуатації_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереміщенняМатеріалівВЕксплуатації_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереміщенняМатеріалівВЕксплуатації_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереміщенняМатеріалівВЕксплуатації_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    