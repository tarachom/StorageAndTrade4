
/*
        ЗбереженіЗвіти_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_Bv2feEDrfUOsrlN9ctqbg")]
partial class ЗбереженіЗвіти_Елемент : DirectoryFormElement
{
    public ЗбереженіЗвіти_Object Елемент { get; init; } = new();

    public Користувачі_Pointer ВласникДляНового = new();

    #region Fields
    Entry Назва = Entry.New();
    TextView Опис = TextView.New();
    Label Інформація = Label.New(null);

    #endregion

    #region TabularParts

    // Таблична частина "ЗвітСторінка"
    ЗбереженіЗвіти_ТабличнаЧастина_ЗвітСторінка ЗвітСторінка = ЗбереженіЗвіти_ТабличнаЧастина_ЗвітСторінка.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Назва:
        Назва.WidthRequest = 500;

        // Опис:
        Опис.WrapMode = WrapMode.Word;

        // Інформація
        Інформація.UseMarkup = true;
        Інформація.UseUnderline = false;
        Інформація.Wrap = true;
    }

    public static ЗбереженіЗвіти_Елемент New()
    {
        ЗбереженіЗвіти_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Опис
        CreateFieldView(vBox, "Опис:", Опис, 1400, 60);

        // Інформація
        CreateField(vBox, null, Інформація);

        // Таблична частина "ЗвітСторінка" 
        CreateTablePart(vBox, null, ЗвітСторінка);
    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
            Елемент.Користувач = ВласникДляНового;

        Назва.SetText(Елемент.Назва);
        Опис.Buffer?.Text = Елемент.Опис;
        Інформація.SetText(Елемент.Інформація);
        Інформація.Visible = !string.IsNullOrEmpty(Елемент.Інформація);

        // Таблична частина "ЗвітСторінка"
        ЗвітСторінка.ЕлементВласник = Елемент;
        await ЗвітСторінка.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
        Елемент.Опис = Опис.Buffer?.Text ?? "";
    }

    #endregion

    protected override async Task<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await ЗвітСторінка.SaveRecords(); // Таблична частина "ЗвітСторінка"
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
