

/*
        ВизначенняФінансовогоРезультату_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;
using StorageAndTrade;

namespace GeneratedCode.Документи;

static class ВизначенняФінансовогоРезультату_Triggers
{
    public static async Task New(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;

        int number = await НумераціяДокументів.ВизначенняФінансовогоРезультату();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ВизначенняФінансовогоРезультату(++number)).ToString("D8");

        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт, ВизначенняФінансовогоРезультату_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        ДокументОбєкт.ДокументБухгалтерськаОперація = new();
        return Task.CompletedTask;
    }

    public static async Task BeforeSave(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ВизначенняФінансовогоРезультату_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";

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

    public static Task AfterSave(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВизначенняФінансовогоРезультату_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
