
/*
    ПоступленняТоварівТаПослуг_Triggers.cs
    Тригери для документу ПоступленняТоварівТаПослуг
*/

using GeneratedCode.Константи;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using AccountingSoftware;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПоступленняТоварівТаПослуг_Triggers
{
    public static async Task New(ПоступленняТоварівТаПослуг_Objest ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ПоступленняТоварівТаПослуг();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПоступленняТоварівТаПослуг(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
        ДокументОбєкт.Менеджер = Program.Користувач;
    }

    public static Task Copying(ПоступленняТоварівТаПослуг_Objest ДокументОбєкт, ПоступленняТоварівТаПослуг_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        ДокументОбєкт.ДокументБухгалтерськаОперація = new();
        return Task.CompletedTask;
    }

    public static async Task BeforeSave(ПоступленняТоварівТаПослуг_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПоступленняТоварівТаПослуг_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";

        if (ДокументОбєкт.ВідобразитиВБухгалтерськомуОбліку)
            ДокументОбєкт.ДокументБухгалтерськаОперація =
                await ФункціїДляДокументів.СтворитиДокументБухгалтерськаОперація(ДокументОбєкт.ДокументБухгалтерськаОперація, new()
                {
                    ДатаДок = ДокументОбєкт.ДатаДок,
                    Організація = ДокументОбєкт.Організація,
                    Основа = ДокументОбєкт.GetBasis()
                });
        else if (!ДокументОбєкт.ДокументБухгалтерськаОперація.IsEmpty())
        {
            await ДокументОбєкт.ДокументБухгалтерськаОперація.SetDeletionLabel(true);
            ДокументОбєкт.ДокументБухгалтерськаОперація = new();
        }
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
