
/*
        СтруктураПідприємства_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_V7KfAbLIX3ab0L6MMev0ug")]
partial class СтруктураПідприємства_Елемент : DirectoryFormElement
{
    public СтруктураПідприємства_Object Елемент { get; init; } = new();

    public СтруктураПідприємства_Pointer РодичДляНового { get; set; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    ФізичніОсоби_PointerControl Керівник = ФізичніОсоби_PointerControl.New();
    СтруктураПідприємства_PointerControl Родич = СтруктураПідприємства_PointerControl.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    Категорії_PointerControl Категорія = Категорії_PointerControl.New();

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

        // Керівник:
        Керівник.Caption = "Керівник";
        Керівник.WidthPresentation = 300;

        // Родич:
        Родич.Caption = "Група";
        Родич.WidthPresentation = 300;

        // Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 400;

        // Категорія:
        Категорія.Caption = "Категорія";
        Категорія.WidthPresentation = 400;
    }

    public static СтруктураПідприємства_Елемент New()
    {
        СтруктураПідприємства_Елемент element = NewWithProperties([]);
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

        // Родич
        CreateField(vBox, null, Родич);

        // Склад
        CreateField(vBox, null, Склад);

        // Категорія
        CreateField(vBox, null, Категорія);

        // Керівник
        CreateField(vBox, null, Керівник);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
            Елемент.Родич = РодичДляНового;
        else
            Родич.OpenFolder = Елемент.UniqueID;

        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        Керівник.Pointer = Елемент.Керівник;
        Родич.Pointer = Елемент.Родич;
        Склад.Pointer = Елемент.Склад;
        Категорія.Pointer = Елемент.Категорія;
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.Керівник = Керівник.Pointer;
        Елемент.Родич = Родич.Pointer;
        Елемент.Склад = Склад.Pointer;
        Елемент.Категорія = Категорія.Pointer;
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
