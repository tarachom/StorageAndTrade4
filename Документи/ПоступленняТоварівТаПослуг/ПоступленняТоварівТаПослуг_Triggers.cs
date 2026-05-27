
/*
    ПоступленняТоварівТаПослуг_Triggers.cs
    Тригери для документу ПоступленняТоварівТаПослуг
*/

using GeneratedCode.Константи;
using GeneratedCode.Довідники;
using AccountingSoftware;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПоступленняТоварівТаПослуг_Triggers
{
    public static Task New(ПоступленняТоварівТаПослуг_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.ПоступленняТоварівТаПослуг_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(ПоступленняТоварівТаПослуг_Objest ДокументОбєкт, ПоступленняТоварівТаПослуг_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПоступленняТоварівТаПослуг_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПоступленняТоварівТаПослуг_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПоступленняТоварівТаПослуг_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(ПоступленняТоварівТаПослуг_Objest ДокументОбєкт, bool label)
    {
        // Помітка на видалення всіх партій
        if (label)
        {
            ПартіяТоварівКомпозит_Select select = new();
            select.QuerySelect.Where.AddRange([
                new(ПартіяТоварівКомпозит_Const.ПоступленняТоварівТаПослуг, Comparison.EQ, ДокументОбєкт.UniqueID.UGuid),
                new(ПартіяТоварівКомпозит_Const.DELETION_LABEL, Comparison.NOT, true)
            ]);
            await select.Select();
            while (select.MoveNext())
                if (select.Current != null)
                    await select.Current.SetDeletionLabel();
        }
    }

    public static Task BeforeDelete(ПоступленняТоварівТаПослуг_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
