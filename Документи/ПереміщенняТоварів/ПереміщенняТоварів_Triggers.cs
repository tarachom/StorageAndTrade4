
/*
    ПереміщенняТоварів_Triggers.cs
    Тригери для документу ПереміщенняТоварів
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПереміщенняТоварів_Triggers
{
    public static async Task New(ПереміщенняТоварів_Objest ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ПереміщенняТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПереміщенняТоварів(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(ПереміщенняТоварів_Objest ДокументОбєкт, ПереміщенняТоварів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static async Task BeforeSave(ПереміщенняТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПереміщенняТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";

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

    public static Task AfterSave(ПереміщенняТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПереміщенняТоварів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПереміщенняТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
