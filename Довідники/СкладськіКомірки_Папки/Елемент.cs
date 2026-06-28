
/*
        СкладськіКомірки_Папки_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_9B8CJcwBDkCf4iTpRvsOvA")]
partial class СкладськіКомірки_Папки_Елемент : DirectoryFormElement
{
    public СкладськіКомірки_Папки_Object Елемент { get; init; } = new();

    public СкладськіПриміщення_Pointer ВласникДляНового = new();

    public СкладськіКомірки_Папки_Pointer РодичДляНового { get; set; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    СкладськіКомірки_Папки_PointerControl Родич = СкладськіКомірки_Папки_PointerControl.New();
    СкладськіПриміщення_PointerControl Власник = СкладськіПриміщення_PointerControl.New();

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

        // Родич:
        Родич.Caption = "Папка";
        Родич.WidthPresentation = 300;

        // Власник:
        Власник.Caption = "Приміщення";
        Власник.WidthPresentation = 300;
    }

    public static СкладськіКомірки_Папки_Елемент New()
    {
        СкладськіКомірки_Папки_Елемент element = NewWithProperties([]);
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

        // Родич
        CreateField(vBox, null, Родич);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Власник
        CreateField(vBox, null, Власник);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Родич = РодичДляНового;
            Елемент.Власник = ВласникДляНового;
        }
        else
            Родич.OpenFolder = Елемент.UniqueID;

        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        Родич.Pointer = Елемент.Родич;
        Власник.Pointer = Елемент.Власник;
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.Родич = Родич.Pointer;
        Елемент.Власник = Власник.Pointer;
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
