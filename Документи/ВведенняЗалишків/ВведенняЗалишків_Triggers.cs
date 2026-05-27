
/*
    ВведенняЗалишків_Triggers.cs
    Тригери для документу ВведенняЗалишків
*/

using GeneratedCode.Константи;
using GeneratedCode.Довідники;
using StorageAndTrade;
using AccountingSoftware;

namespace GeneratedCode.Документи;

class ВведенняЗалишків_Triggers
{
    public static Task New(ВведенняЗалишків_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.ВведенняЗалишків_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(ВведенняЗалишків_Objest ДокументОбєкт, ВведенняЗалишків_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВведенняЗалишків_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ВведенняЗалишків_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВведенняЗалишків_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(ВведенняЗалишків_Objest ДокументОбєкт, bool label)
    {
        // Помітка на виделення всіх партій
        if (label)
        {
            ПартіяТоварівКомпозит_Select select = new();
            select.QuerySelect.Where.AddRange([
                new(ПартіяТоварівКомпозит_Const.ВведенняЗалишків, Comparison.EQ, ДокументОбєкт.UniqueID.UGuid),
                new(ПартіяТоварівКомпозит_Const.DELETION_LABEL, Comparison.NOT, true)
            ]);
            await select.Select();
            while (select.MoveNext())
                if (select.Current != null)
                    await select.Current.SetDeletionLabel();
        }
    }

    public static Task BeforeDelete(ВведенняЗалишків_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
