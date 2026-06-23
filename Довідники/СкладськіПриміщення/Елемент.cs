
/*
        СкладськіПриміщення_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_31dVji9NVku2b0mX4UhLkg")]
partial class СкладськіПриміщення_Елемент : DirectoryFormElement
{
    public СкладськіПриміщення_Object Елемент { get; init; } = new();

    public Склади_Pointer ВласникДляНового = new();

    #region Fields
    Entry Назва = Entry.New();
    ComboBoxText НалаштуванняАдресногоЗберігання = ComboBoxText.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Назва:
        Назва.WidthRequest = 300;

        // НалаштуванняАдресногоЗберігання:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_List())
                НалаштуванняАдресногоЗберігання.Append(field.Value.ToString(), field.Name);

            НалаштуванняАдресногоЗберігання.AddController(FunctionForComboBox.DisableScrolling());
        }

        // Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;
    }

    public static СкладськіПриміщення_Елемент New()
    {
        СкладськіПриміщення_Елемент element = NewWithProperties([]);
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
        // Назва
        CreateField(vBox, "Назва:", Назва);

        // НалаштуванняАдресногоЗберігання
        CreateField(vBox, "Адресне зберігання:", НалаштуванняАдресногоЗберігання);

        // Склад
        CreateField(vBox, null, Склад);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
            Елемент.Склад = ВласникДляНового;
        Назва.SetText(Елемент.Назва);
        НалаштуванняАдресногоЗберігання.ActiveId = Елемент.НалаштуванняАдресногоЗберігання.ToString();
        Склад.Pointer = Елемент.Склад;
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
        Елемент.НалаштуванняАдресногоЗберігання = ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_FindByName(НалаштуванняАдресногоЗберігання.ActiveId);
        Елемент.Склад = Склад.Pointer;
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
