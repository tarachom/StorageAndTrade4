
/*
        ВидиЗапасів_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_0AFwsCQSc0KNVZAAUqXanA")]
partial class ВидиЗапасів_Елемент : DirectoryFormElement
{
    public ВидиЗапасів_Object Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    ComboBoxText ТипЗапасів = ComboBoxText.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Код:
        Код.WidthRequest = 100;

        // Назва:
        Назва.WidthRequest = 500;

        // Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        // ТипЗапасів:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипЗапасів_List())
                ТипЗапасів.Append(field.Value.ToString(), field.Name);

            ТипЗапасів.Active = 0;
            ТипЗапасів.AddController(FunctionForComboBox.DisableScrolling());
        }

        // Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        // Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        // Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;
    }

    public static ВидиЗапасів_Елемент New()
    {
        ВидиЗапасів_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DirectoryElementSmall Interface = FunctionForInterfaces.ForDirectorySmall();

    protected override void BuildInterface()
    {
        Append(Interface.MainBox);
        CreateStart(Interface.TopStartBox);
    }

    void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Організація
        CreateField(vBox, null, Організація);

        // ТипЗапасів
        CreateField(vBox, "Тип запасів:", ТипЗапасів);

        // Валюта
        CreateField(vBox, null, Валюта);

        // Контрагент
        CreateField(vBox, null, Контрагент);

        // Договір
        CreateField(vBox, null, Договір);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        Організація.Pointer = Елемент.Організація;
        ТипЗапасів.ActiveId = Елемент.ТипЗапасів.ToString();
        Валюта.Pointer = Елемент.Валюта;
        Контрагент.Pointer = Елемент.Контрагент;
        Договір.Pointer = Елемент.Договір;
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.Організація = Організація.Pointer;
        Елемент.ТипЗапасів = ПсевдонімиПерелічення.ТипЗапасів_FindByName(ТипЗапасів.ActiveId);
        Елемент.Валюта = Валюта.Pointer;
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.Договір = Договір.Pointer;
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
