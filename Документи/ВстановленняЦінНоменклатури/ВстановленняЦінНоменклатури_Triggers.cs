
/*
    ВстановленняЦінНоменклатури_Triggers.cs
    Тригери для документу ВстановленняЦінНоменклатури
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ВстановленняЦінНоменклатури_Triggers
{
    public static Task New(ВстановленняЦінНоменклатури_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.ВстановленняЦінНоменклатури_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(ВстановленняЦінНоменклатури_Objest ДокументОбєкт, ВстановленняЦінНоменклатури_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВстановленняЦінНоменклатури_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ВстановленняЦінНоменклатури_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВстановленняЦінНоменклатури_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВстановленняЦінНоменклатури_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВстановленняЦінНоменклатури_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
