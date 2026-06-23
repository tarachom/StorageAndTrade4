
/*
    ПрихіднийКасовийОрдер_Triggers.cs
    Тригери для документу ПрихіднийКасовийОрдер
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ПрихіднийКасовийОрдер_Triggers
{
    public static async Task New(ПрихіднийКасовийОрдер_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ПрихіднийКасовийОрдер();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПрихіднийКасовийОрдер(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(ПрихіднийКасовийОрдер_Object ДокументОбєкт, ПрихіднийКасовийОрдер_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        ДокументОбєкт.ДокументБухгалтерськаОперація = new();
        return Task.CompletedTask;
    }

    public static async Task BeforeSave(ПрихіднийКасовийОрдер_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПрихіднийКасовийОрдер_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";

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

    public static Task AfterSave(ПрихіднийКасовийОрдер_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПрихіднийКасовийОрдер_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПрихіднийКасовийОрдер_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}