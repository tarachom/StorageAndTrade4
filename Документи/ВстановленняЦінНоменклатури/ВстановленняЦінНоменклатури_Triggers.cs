
/*
    ВстановленняЦінНоменклатури_Triggers.cs
    Тригери для документу ВстановленняЦінНоменклатури
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ВстановленняЦінНоменклатури_Triggers
{
    public static async Task New(ВстановленняЦінНоменклатури_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ВстановленняЦінНоменклатури();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ВстановленняЦінНоменклатури(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(ВстановленняЦінНоменклатури_Object ДокументОбєкт, ВстановленняЦінНоменклатури_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВстановленняЦінНоменклатури_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ВстановленняЦінНоменклатури_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВстановленняЦінНоменклатури_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВстановленняЦінНоменклатури_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВстановленняЦінНоменклатури_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
