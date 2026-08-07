
/*
        КласифікаторОдиницьВиміру_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_SdafARFrlHOJscp7auj1A")]
partial class КласифікаторОдиницьВиміру_Елемент : DirectoryFormElement
{
    public КласифікаторОдиницьВиміру_Object Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Entry ПовнаНазва = Entry.New();
    Entry МіжнароднеСкорочення = Entry.New();

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

        // ПовнаНазва:
        ПовнаНазва.WidthRequest = 500;

        // МіжнароднеСкорочення:
        МіжнароднеСкорочення.WidthRequest = 200;
    }

    public static КласифікаторОдиницьВиміру_Елемент New()
    {
        КласифікаторОдиницьВиміру_Елемент element = NewWithProperties([]);
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

        // МіжнароднеСкорочення
        CreateField(vBox, "Міжнародне cкорочення:", МіжнароднеСкорочення);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // ПовнаНазва
        CreateField(vBox, "Повна назва:", ПовнаНазва);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        ПовнаНазва.SetText(Елемент.ПовнаНазва);
        МіжнароднеСкорочення.SetText(Елемент.МіжнароднеСкорочення);
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.ПовнаНазва = ПовнаНазва.GetText();
        Елемент.МіжнароднеСкорочення = МіжнароднеСкорочення.GetText();
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
