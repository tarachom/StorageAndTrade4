
/*
        БанківськіРахункиОрганізацій_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_SHvnji4zE2UeoPOKVRw")]
partial class БанківськіРахункиОрганізацій_Елемент : DirectoryFormElement
{
    public БанківськіРахункиОрганізацій_Object Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Банки_PointerControl Банк = Банки_PointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Entry НомерРахунку = Entry.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();

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

        // Банк:
        Банк.Caption = "Банк";
        Банк.WidthPresentation = 300;

        // Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        // НомерРахунку:
        НомерРахунку.WidthRequest = 300;

        // Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        // Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

    }

    public static БанківськіРахункиОрганізацій_Елемент New()
    {
        БанківськіРахункиОрганізацій_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DirectoryElementSmall Interface;

    protected override void BuildInterface()
    {
        Interface = FunctionForInterfaces.ForDirectorySmall();

        Append(Interface.MainBox);
        CreateStart(Interface.TopStartBox);
    }

    void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Банк
        CreateField(vBox, null, Банк);

        // Організація
        CreateField(vBox, null, Організація);

        // НомерРахунку
        CreateField(vBox, "Номер рахунку:", НомерРахунку);

        // Валюта
        CreateField(vBox, null, Валюта);

        // Підрозділ
        CreateField(vBox, null, Підрозділ);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        Банк.Pointer = Елемент.Банк;
        Організація.Pointer = Елемент.Організація;
        НомерРахунку.SetText(Елемент.НомерРахунку);
        Валюта.Pointer = Елемент.Валюта;
        Підрозділ.Pointer = Елемент.Підрозділ;
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.Банк = Банк.Pointer;
        Елемент.Організація = Організація.Pointer;
        Елемент.НомерРахунку = НомерРахунку.GetText();
        Елемент.Валюта = Валюта.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
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
