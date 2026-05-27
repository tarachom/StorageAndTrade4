
/*
    РеалізаціяТоварівТаПослуг_Triggers.cs
    Тригери для документу РеалізаціяТоварівТаПослуг
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class РеалізаціяТоварівТаПослуг_Triggers
{
    public static Task New(РеалізаціяТоварівТаПослуг_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.РеалізаціяТоварівТаПослуг_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(РеалізаціяТоварівТаПослуг_Objest ДокументОбєкт, РеалізаціяТоварівТаПослуг_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РеалізаціяТоварівТаПослуг_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РеалізаціяТоварівТаПослуг_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РеалізаціяТоварівТаПослуг_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РеалізаціяТоварівТаПослуг_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РеалізаціяТоварівТаПослуг_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
