

/*
        Амортизація_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;
using StorageAndTrade;

namespace GeneratedCode.Документи;

static class Амортизація_Triggers
{
    public static async Task New(Амортизація_Objest ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;

        int number = await НумераціяДокументів.Амортизація();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.Амортизація(++number)).ToString("D8");

        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(Амортизація_Objest ДокументОбєкт, Амортизація_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        ДокументОбєкт.ДокументБухгалтерськаОперація = new();
        return Task.CompletedTask;
    }

    public static async Task BeforeSave(Амортизація_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Амортизація_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";

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

    public static Task AfterSave(Амортизація_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Амортизація_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Амортизація_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
