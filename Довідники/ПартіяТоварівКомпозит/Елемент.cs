
/*
        ПартіяТоварівКомпозит_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_tD9zKdrSUESFtGALCHPudw")]
partial class ПартіяТоварівКомпозит_Елемент : DirectoryFormElement
{
    public ПартіяТоварівКомпозит_Objest Елемент { get; init; } = new();

    #region Fields
    Entry Назва = Entry.New();
    DateTimeControl Дата = DateTimeControl.New();
    ComboBoxText ТипДокументу = ComboBoxText.New();
    ПоступленняТоварівТаПослуг_PointerControl ПоступленняТоварівТаПослуг = ПоступленняТоварівТаПослуг_PointerControl.New();
    ВведенняЗалишків_PointerControl ВведенняЗалишків = ВведенняЗалишків_PointerControl.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Назва:
        Назва.WidthRequest = 300;

        // ТипДокументу:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипДокументуПартіяТоварівКомпозит_List())
                ТипДокументу.Append(field.Value.ToString(), field.Name);

            ТипДокументу.AddController(FunctionForComboBox.DisableScrolling());
        }

        // ПоступленняТоварівТаПослуг:
        ПоступленняТоварівТаПослуг.Caption = "Поступлення товарів та послуг";
        ПоступленняТоварівТаПослуг.WidthPresentation = 300;

        // ВведенняЗалишків:
        ВведенняЗалишків.Caption = "Введення залишків";
        ВведенняЗалишків.WidthPresentation = 300;
    }

    public static ПартіяТоварівКомпозит_Елемент New()
    {
        ПартіяТоварівКомпозит_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Дата
        CreateField(vBox, "Дата:", Дата);

        // ТипДокументу
        CreateField(vBox, "Тип документу:", ТипДокументу);

        // ПоступленняТоварівТаПослуг
        CreateField(vBox, null, ПоступленняТоварівТаПослуг);

        // ВведенняЗалишків
        CreateField(vBox, null, ВведенняЗалишків);
    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Назва.SetText(Елемент.Назва);
        Дата.Value = Елемент.Дата;
        ТипДокументу.ActiveId = Елемент.ТипДокументу.ToString();
        ПоступленняТоварівТаПослуг.Pointer = Елемент.ПоступленняТоварівТаПослуг;
        ВведенняЗалишків.Pointer = Елемент.ВведенняЗалишків;
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
        Елемент.Дата = Дата.Value;
        Елемент.ТипДокументу = ПсевдонімиПерелічення.ТипДокументуПартіяТоварівКомпозит_FindByName(ТипДокументу.ActiveId);
        Елемент.ПоступленняТоварівТаПослуг = ПоступленняТоварівТаПослуг.Pointer;
        Елемент.ВведенняЗалишків = ВведенняЗалишків.Pointer;
    }

    #endregion

    protected override async Task<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                isSaved = true;
            }
        }
        catch (Exception ex)
        {
            ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
