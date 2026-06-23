

/*
        СписанняВитратМайбутніхПеріодів_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняВитратМайбутніхПеріодів_Triggers
{
    public static async Task New(СписанняВитратМайбутніхПеріодів_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняВитратМайбутніхПеріодів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняВитратМайбутніхПеріодів(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняВитратМайбутніхПеріодів_Object ДокументОбєкт, СписанняВитратМайбутніхПеріодів_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняВитратМайбутніхПеріодів_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняВитратМайбутніхПеріодів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняВитратМайбутніхПеріодів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняВитратМайбутніхПеріодів_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняВитратМайбутніхПеріодів_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    