

/*
        ПереміщенняМатеріалівВЕксплуатації_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПереміщенняМатеріалівВЕксплуатації_Triggers
{
    public static  Task New(ПереміщенняМатеріалівВЕксплуатації_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        return Task.CompletedTask;
                    
    }

    public static Task Copying(ПереміщенняМатеріалівВЕксплуатації_Objest ДокументОбєкт, ПереміщенняМатеріалівВЕксплуатації_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПереміщенняМатеріалівВЕксплуатації_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереміщенняМатеріалівВЕксплуатації_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПереміщенняМатеріалівВЕксплуатації_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереміщенняМатеріалівВЕксплуатації_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереміщенняМатеріалівВЕксплуатації_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    