
/*
        ПакуванняОдиниціВиміру_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Константи;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_b9afAT3lDnmUQPdz9QehQ")]
partial class ПакуванняОдиниціВиміру_Елемент : DirectoryFormElement
{
    public ПакуванняОдиниціВиміру_Object Елемент { get; init; } = new();

    public Номенклатура_Pointer ВласникДляНового = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Entry НазваПовна = Entry.New();
    Номенклатура_PointerControl Номенклатура = Номенклатура_PointerControl.New();
    КласифікаторОдиницьВиміру_PointerControl ОдиницяЗаКласифікатором = КласифікаторОдиницьВиміру_PointerControl.New();
    NumericControl Коєфіціент = NumericControl.New();
    NumericControl Вага = NumericControl.New();
    NumericControl Обєм = NumericControl.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Код:
        Код.WidthRequest = 100;

        // Назва:
        Назва.WidthRequest = 300;

        // НазваПовна:
        НазваПовна.WidthRequest = 300;

        // Номенклатура:
        Номенклатура.Caption = "Номенклатура";
        Номенклатура.WidthPresentation = 300;

        // ОдиницяЗаКласифікатором:
        ОдиницяЗаКласифікатором.Caption = "За класифікатором";
        ОдиницяЗаКласифікатором.WidthPresentation = 300;
    }

    public static ПакуванняОдиниціВиміру_Елемент New()
    {
        ПакуванняОдиниціВиміру_Елемент element = NewWithProperties([]);
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

        // НазваПовна
        CreateField(vBox, "Опис:", НазваПовна);

        // Номенклатура
        CreateField(vBox, null, Номенклатура);

        // ОдиницяЗаКласифікатором
        CreateField(vBox, null, ОдиницяЗаКласифікатором);

        // Коєфіціент
        CreateField(vBox, "Коєфіціент:", Коєфіціент);

        // Вага
        CreateField(vBox, "Вага:", Вага);

        // Обєм
        CreateField(vBox, "Обєм:", Обєм);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Номенклатура = ВласникДляНового;
            Елемент.ОдиницяЗаКласифікатором = await ЗначенняТипові.ОсновнаОдиницяВиміруЗаКласифікатором();
        }

        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        НазваПовна.SetText(Елемент.НазваПовна);
        Номенклатура.Pointer = Елемент.Номенклатура;
        ОдиницяЗаКласифікатором.Pointer = Елемент.ОдиницяЗаКласифікатором;
        Коєфіціент.Value = Елемент.Коєфіціент;
        Вага.Value = Елемент.Вага;
        Обєм.Value = Елемент.Обєм;
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.НазваПовна = НазваПовна.GetText();
        Елемент.Номенклатура = Номенклатура.Pointer;
        Елемент.ОдиницяЗаКласифікатором = ОдиницяЗаКласифікатором.Pointer;
        Елемент.Коєфіціент = Коєфіціент.Value;
        Елемент.Вага = Вага.Value;
        Елемент.Обєм = Обєм.Value;
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
