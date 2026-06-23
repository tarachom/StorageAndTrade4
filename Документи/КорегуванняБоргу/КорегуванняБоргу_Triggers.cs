
/*
    КорегуванняБоргу_Triggers.cs
    Тригери для документу КорегуванняБоргу
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class КорегуванняБоргу_Triggers
{
    public static async Task New(КорегуванняБоргу_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.КорегуванняБоргу();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.КорегуванняБоргу(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(КорегуванняБоргу_Object ДокументОбєкт, КорегуванняБоргу_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        ДокументОбєкт.ДокументБухгалтерськаОперація = new();
        return Task.CompletedTask;
    }

    public static async Task BeforeSave(КорегуванняБоргу_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{КорегуванняБоргу_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";

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

    public static Task AfterSave(КорегуванняБоргу_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(КорегуванняБоргу_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(КорегуванняБоргу_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}