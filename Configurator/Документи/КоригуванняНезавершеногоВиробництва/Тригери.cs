

/*
        КоригуванняНезавершеногоВиробництва_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class КоригуванняНезавершеногоВиробництва_Triggers
{
    public static async Task New(КоригуванняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.КоригуванняНезавершеногоВиробництва();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.КоригуванняНезавершеногоВиробництва(++number)).ToString("D8");
                    
    }

    public static Task Copying(КоригуванняНезавершеногоВиробництва_Objest ДокументОбєкт, КоригуванняНезавершеногоВиробництва_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(КоригуванняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{КоригуванняНезавершеногоВиробництва_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(КоригуванняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(КоригуванняНезавершеногоВиробництва_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(КоригуванняНезавершеногоВиробництва_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    