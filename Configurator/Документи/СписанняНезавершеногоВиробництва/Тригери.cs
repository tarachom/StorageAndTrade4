

/*
        СписанняНезавершеногоВиробництва_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняНезавершеногоВиробництва_Triggers
{
    public static async Task New(СписанняНезавершеногоВиробництва_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняНезавершеногоВиробництва();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняНезавершеногоВиробництва(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняНезавершеногоВиробництва_Object ДокументОбєкт, СписанняНезавершеногоВиробництва_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняНезавершеногоВиробництва_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняНезавершеногоВиробництва_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняНезавершеногоВиробництва_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняНезавершеногоВиробництва_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняНезавершеногоВиробництва_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    