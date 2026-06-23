

/*
        ПрийняттяДоОбліку_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПрийняттяДоОбліку_Triggers
{
    public static async Task New(ПрийняттяДоОбліку_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПрийняттяДоОбліку();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПрийняттяДоОбліку(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПрийняттяДоОбліку_Object ДокументОбєкт, ПрийняттяДоОбліку_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПрийняттяДоОбліку_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрийняттяДоОбліку_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПрийняттяДоОбліку_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрийняттяДоОбліку_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрийняттяДоОбліку_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    