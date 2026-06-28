
/*
        КасиККМ_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_DimL1t4YUCkCnrffPHRng")]
partial class КасиККМ_Елемент : DirectoryFormElement
{
    public КасиККМ_Object Елемент { get; init; } = new();

    #region Fields
    Entry Назва = Entry.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    ComboBoxText Тип = ComboBoxText.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Назва:
        Назва.WidthRequest = 500;

        // Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        // Тип:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипККМ_List())
                Тип.Append(field.Value.ToString(), field.Name);

            Тип.Active = 0;
            Тип.AddController(FunctionForComboBox.DisableScrolling());
        }

        // Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;
    }

    public static КасиККМ_Елемент New()
    {
        КасиККМ_Елемент element = NewWithProperties([]);
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
        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Склад
        CreateField(vBox, null, Склад);

        // Тип
        CreateField(vBox, "Тип:", Тип);

        // Валюта
        CreateField(vBox, null, Валюта);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Назва.SetText(Елемент.Назва);
        Склад.Pointer = Елемент.Склад;
        Тип.ActiveId = Елемент.Тип.ToString();
        Валюта.Pointer = Елемент.Валюта;
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
        Елемент.Склад = Склад.Pointer;
        Елемент.Тип = ПсевдонімиПерелічення.ТипККМ_FindByName(Тип.ActiveId);
        Елемент.Валюта = Валюта.Pointer;
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
