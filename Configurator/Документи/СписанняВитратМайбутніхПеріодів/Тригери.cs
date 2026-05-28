

/*
        СписанняВитратМайбутніхПеріодів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняВитратМайбутніхПеріодів_Triggers
{
    public static async Task New(СписанняВитратМайбутніхПеріодів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняВитратМайбутніхПеріодів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняВитратМайбутніхПеріодів(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняВитратМайбутніхПеріодів_Objest ДокументОбєкт, СписанняВитратМайбутніхПеріодів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняВитратМайбутніхПеріодів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняВитратМайбутніхПеріодів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняВитратМайбутніхПеріодів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняВитратМайбутніхПеріодів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняВитратМайбутніхПеріодів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    