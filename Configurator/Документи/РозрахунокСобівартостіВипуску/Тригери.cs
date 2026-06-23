

/*
        РозрахунокСобівартостіВипуску_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class РозрахунокСобівартостіВипуску_Triggers
{
    public static async Task New(РозрахунокСобівартостіВипуску_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.РозрахунокСобівартостіВипуску();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.РозрахунокСобівартостіВипуску(++number)).ToString("D8");
                    
    }

    public static Task Copying(РозрахунокСобівартостіВипуску_Object ДокументОбєкт, РозрахунокСобівартостіВипуску_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РозрахунокСобівартостіВипуску_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РозрахунокСобівартостіВипуску_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РозрахунокСобівартостіВипуску_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РозрахунокСобівартостіВипуску_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РозрахунокСобівартостіВипуску_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    