

/*
        ПрийняттяДоОбліку_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПрийняттяДоОбліку_Triggers
{
    public static async Task New(ПрийняттяДоОбліку_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПрийняттяДоОбліку();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПрийняттяДоОбліку(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПрийняттяДоОбліку_Objest ДокументОбєкт, ПрийняттяДоОбліку_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПрийняттяДоОбліку_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрийняттяДоОбліку_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПрийняттяДоОбліку_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрийняттяДоОбліку_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрийняттяДоОбліку_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    