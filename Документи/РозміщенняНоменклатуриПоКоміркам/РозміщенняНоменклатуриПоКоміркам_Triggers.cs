
/*
    РозміщенняНоменклатуриПоКоміркам_Triggers.cs
    Тригери для документу РозміщенняНоменклатуриПоКоміркам
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class РозміщенняНоменклатуриПоКоміркам_Triggers
{
    public static Task New(РозміщенняНоменклатуриПоКоміркам_Objest ДокументОбєкт)
    {
        ДокументОбєкт.НомерДок = (++НумераціяДокументів.РозміщенняНоменклатуриПоКоміркам_Const).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;

        return Task.CompletedTask;
    }

    public static Task Copying(РозміщенняНоменклатуриПоКоміркам_Objest ДокументОбєкт, РозміщенняНоменклатуриПоКоміркам_Objest Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РозміщенняНоменклатуриПоКоміркам_Objest ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РозміщенняНоменклатуриПоКоміркам_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РозміщенняНоменклатуриПоКоміркам_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РозміщенняНоменклатуриПоКоміркам_Objest ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РозміщенняНоменклатуриПоКоміркам_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
