

/*
        ЗаписКнигиПридбання_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ЗаписКнигиПридбання_Triggers
{
    public static async Task New(ЗаписКнигиПридбання_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ЗаписКнигиПридбання();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ЗаписКнигиПридбання(++number)).ToString("D8");
                    
    }

    public static Task Copying(ЗаписКнигиПридбання_Object ДокументОбєкт, ЗаписКнигиПридбання_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗаписКнигиПридбання_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ЗаписКнигиПридбання_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗаписКнигиПридбання_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗаписКнигиПридбання_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗаписКнигиПридбання_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    