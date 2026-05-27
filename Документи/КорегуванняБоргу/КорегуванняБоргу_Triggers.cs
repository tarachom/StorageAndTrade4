
/*
    КорегуванняБоргу_Triggers.cs
    Тригери для документу КорегуванняБоргу
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Документи;

class КорегуванняБоргу_Triggers
{
    public static Task New(КорегуванняБоргу_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.КорегуванняБоргу_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        return Task.CompletedTask;
    }

    public static Task Copying(КорегуванняБоргу_Objest ДокументОбєкт, КорегуванняБоргу_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(КорегуванняБоргу_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{КорегуванняБоргу_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(КорегуванняБоргу_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(КорегуванняБоргу_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(КорегуванняБоргу_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}