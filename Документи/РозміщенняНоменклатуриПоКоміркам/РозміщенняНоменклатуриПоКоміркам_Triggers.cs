
/*
    РозміщенняНоменклатуриПоКоміркам_Triggers.cs
    Тригери для документу РозміщенняНоменклатуриПоКоміркам
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class РозміщенняНоменклатуриПоКоміркам_Triggers
{
    public static async Task New(РозміщенняНоменклатуриПоКоміркам_Object ДокументОбєкт)
    {
        int number = await НумераціяДокументів.РозміщенняНоменклатуриПоКоміркам();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.РозміщенняНоменклатуриПоКоміркам(++number)).ToString("D8");
        ДокументОбєкт.ДатаДок = DateTime.Now;
        ДокументОбєкт.Автор = Program.Користувач;
    }

    public static Task Copying(РозміщенняНоменклатуриПоКоміркам_Object ДокументОбєкт, РозміщенняНоменклатуриПоКоміркам_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(РозміщенняНоменклатуриПоКоміркам_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{РозміщенняНоменклатуриПоКоміркам_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(РозміщенняНоменклатуриПоКоміркам_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(РозміщенняНоменклатуриПоКоміркам_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(РозміщенняНоменклатуриПоКоміркам_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
