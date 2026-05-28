

/*
        СписанняНезавершеногоВиробництва_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class СписанняНезавершеногоВиробництва_Triggers
{
    public static async Task New(СписанняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.СписанняНезавершеногоВиробництва();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.СписанняНезавершеногоВиробництва(++number)).ToString("D8");
                    
    }

    public static Task Copying(СписанняНезавершеногоВиробництва_Objest ДокументОбєкт, СписанняНезавершеногоВиробництва_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(СписанняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{СписанняНезавершеногоВиробництва_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(СписанняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СписанняНезавершеногоВиробництва_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СписанняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    