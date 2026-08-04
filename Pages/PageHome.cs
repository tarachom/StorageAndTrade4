/*

Стартова сторінка

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode;
using GeneratedCode.Документи;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

/// <summary>
/// Стартова сторінка
/// </summary>
[GObject.Subclass<Form>]
partial class PageHome : Form
{
    partial void Initialize()
    {
        {
            ActiveUsersView view = ActiveUsersView.New(Config.Kernel, 800, 300);

            Box hBox = New(Orientation.Horizontal, 0);
            hBox.MarginBottom = 10;
            hBox.Append(view);
            Append(hBox);
        }

        {
            LockObjectsView view = LockObjectsView.New(800, 300);

            Box hBox = New(Orientation.Horizontal, 0);
            hBox.MarginBottom = 10;
            hBox.Append(view);
            Append(hBox);
        }
    }

    /// <summary>
    /// Новий об'єкт
    /// </summary>
    /// <returns>PageHome</returns>
    public static PageHome New()
    {
        PageHome page = NewWithProperties([]);
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return page;
    }

    public async Task SetValue()
    {
        /*
        Номенклатура_Select НоменклатураВибірка2 = new();
        НоменклатураВибірка2.QuerySelect.Field.Add("Категорія");
        var a = await НоменклатураВибірка2.FindByField("Код", "000503");
        if (!a.IsEmpty())
        {
            Console.WriteLine(НоменклатураВибірка2.Категорія);
        }
        */

        /*
        Номенклатура_Select НоменклатураВибірка = new();
        if (await НоменклатураВибірка.SelectByField(["Категорія"], "Код", "000503"))
        {
            Console.WriteLine(НоменклатураВибірка.Категорія);
        }
        */

        /*
        var РахунокКт = await new ПланРахунків_Select().FindByField("Код", "201");
        Console.WriteLine(РахунокКт);

        var РахунокКтList = await new ПланРахунків_Select().FindListByField("Клас", 0);
        Console.WriteLine(РахунокКтList.Count);
        foreach (var item in РахунокКтList)
        {
            Console.WriteLine(item);
        }

        var docs = await new ВиготовленняПродукції_Select().FindListByField("Автор", Program.Користувач.UniqueID.UGuid);
        foreach (var item in docs)
        {
            Console.WriteLine(item);
        }

        Категорії_SelectHierarchical Вибірка = new Категорії_SelectHierarchical();
        Вибірка.QuerySelect.Field.AddRange("МетодСписання", "СтаттяВитрат", Категорії_Const.Назва);
        await Вибірка.Select();
        while (Вибірка.MoveNext())
        {
            if (Вибірка.Current != null)
            {
                Console.WriteLine(Вибірка.Current + " " + Вибірка.Назва + " " + Вибірка.МетодСписання + " " + Вибірка.СтаттяВитрат);
            }
        }
        */


        /*
        var Вибірка = new ВиготовленняПродукції_Select();
        Вибірка.QuerySelect.Field.AddRange([
            ВиготовленняПродукції_Const.Назва,
            ВиготовленняПродукції_Const.Валюта,
            ВиготовленняПродукції_Const.Організація,
            ВиготовленняПродукції_Const.Основа
        ]);

        await Вибірка.Select();
        while (Вибірка.MoveNext())
        {
            ВиготовленняПродукції_Pointer? Вказівник = Вибірка.Current;
            if (Вказівник != null)
            {
                Console.WriteLine(Вибірка.Назва + " " + Вибірка.Організація + " " + Вибірка.Основа + " " + Вибірка.Валюта);
            }
        }
        */
    }
}