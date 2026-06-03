
/*
        ВидиНоменклатури_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_oo2txpN6w0uG3neeA0RpQ")]
partial class ВидиНоменклатури_Елемент : DirectoryFormElement
{
    public ВидиНоменклатури_Objest Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    TextView Опис = TextView.New();
    ПакуванняОдиниціВиміру_PointerControl ОдиницяВиміру = ПакуванняОдиниціВиміру_PointerControl.New();
    ComboBoxText ТипНоменклатури = ComboBoxText.New();

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

        // Опис:
        Опис.WrapMode = WrapMode.Word;

        // ОдиницяВиміру:
        ОдиницяВиміру.Caption = "Пакування:";
        ОдиницяВиміру.WidthPresentation = 300;

        // ТипНоменклатури:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипиНоменклатури_List())
                ТипНоменклатури.Append(field.Value.ToString(), field.Name);

            ТипНоменклатури.Active = 0;
            ТипНоменклатури.AddController(FunctionForComboBox.DisableScrolling());
        }
    }

    public static ВидиНоменклатури_Елемент New()
    {
        ВидиНоменклатури_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // ОдиницяВиміру
        CreateField(vBox, null, ОдиницяВиміру);

        // ТипНоменклатури
        CreateField(vBox, "Тип:", ТипНоменклатури);

        // Опис
        CreateFieldView(vBox, "Опис:", Опис, 500, 200);
    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        Опис.Buffer?.Text = Елемент.Опис;
        ОдиницяВиміру.Pointer = Елемент.ОдиницяВиміру;
        ТипНоменклатури.ActiveId = Елемент.ТипНоменклатури.ToString();
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.Опис = Опис.Buffer?.Text ?? "";
        Елемент.ОдиницяВиміру = ОдиницяВиміру.Pointer;
        Елемент.ТипНоменклатури = ПсевдонімиПерелічення.ТипиНоменклатури_FindByName(ТипНоменклатури.ActiveId);
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
