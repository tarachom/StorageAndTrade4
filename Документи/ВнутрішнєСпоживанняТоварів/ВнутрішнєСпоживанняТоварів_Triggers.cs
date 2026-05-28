
/*
    ВнутрішнєСпоживанняТоварів_Triggers.cs
    Тригери для документу ВнутрішнєСпоживанняТоварів
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class ВнутрішнєСпоживанняТоварів_Triggers
{
    public static async Task New(ВнутрішнєСпоживанняТоварів_Objest ДокументОбєкт)
    {
        int number = await НумераціяДокументів.ВнутрішнєСпоживанняТоварів();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ВнутрішнєСпоживанняТоварів(++number)).ToString("D8");

        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(ВнутрішнєСпоживанняТоварів_Objest ДокументОбєкт, ВнутрішнєСпоживанняТоварів_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ВнутрішнєСпоживанняТоварів_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ВнутрішнєСпоживанняТоварів_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ВнутрішнєСпоживанняТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ВнутрішнєСпоживанняТоварів_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ВнутрішнєСпоживанняТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}