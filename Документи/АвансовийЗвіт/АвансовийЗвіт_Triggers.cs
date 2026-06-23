

/*
        АвансовийЗвіт_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;
using StorageAndTrade;

namespace GeneratedCode.Документи;

static class АвансовийЗвіт_Triggers
{
    public static async Task New(АвансовийЗвіт_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;

        int number = await НумераціяДокументів.АвансовийЗвіт();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.АвансовийЗвіт(++number)).ToString("D8");

        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(АвансовийЗвіт_Object ДокументОбєкт, АвансовийЗвіт_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        ДокументОбєкт.ДокументБухгалтерськаОперація = new();
        return Task.CompletedTask;
    }

    public static async Task BeforeSave(АвансовийЗвіт_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{АвансовийЗвіт_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";

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

    public static Task AfterSave(АвансовийЗвіт_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(АвансовийЗвіт_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(АвансовийЗвіт_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
