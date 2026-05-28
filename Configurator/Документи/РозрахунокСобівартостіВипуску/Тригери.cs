

/*
        РозрахунокСобівартостіВипуску_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class РозрахунокСобівартостіВипуску_Triggers
{
    public static async Task New(РозрахунокСобівартостіВипуску_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.РозрахунокСобівартостіВипуску();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.РозрахунокСобівартостіВипуску(++number)).ToString("D8");
                    
    }

    public static Task Copying(РозрахунокСобівартостіВипуску_Objest ДокументОбєкт, РозрахунокСобівартостіВипуску_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РозрахунокСобівартостіВипуску_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РозрахунокСобівартостіВипуску_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РозрахунокСобівартостіВипуску_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РозрахунокСобівартостіВипуску_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РозрахунокСобівартостіВипуску_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    