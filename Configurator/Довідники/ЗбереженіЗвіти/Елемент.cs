
/*
        ЗбереженіЗвіти_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_Bv2feEDrfUOsrlN9ctqbg")]
partial class ЗбереженіЗвіти_Елемент : DirectoryFormElement
{
    public ЗбереженіЗвіти_Objest Елемент { get; init; } = new();
    
    public Користувачі_Pointer ВласникДляНового = new();
    
    #region Fields
    DateTimeControl Додано = DateTimeControl.New();
            Entry Назва = Entry.New();
                    TextView Опис = TextView.New();
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "ЗвітСторінка"
        ЗбереженіЗвіти_ТабличнаЧастина_ЗвітСторінка ЗвітСторінка = ЗбереженіЗвіти_ТабличнаЧастина_ЗвітСторінка.New();
    
    #endregion

    partial void Initialize()
    { 
        Element = Елемент;

        
            // Додано:
            
            // Назва:
            Назва.WidthRequest = 300;
                        
            // Опис:
            Опис.WrapMode = WrapMode.Word;
                        
    }

    public static ЗбереженіЗвіти_Елемент New()
    {
        ЗбереженіЗвіти_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Додано
            CreateField(vBox, "Додано:", Додано);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Опис
            CreateFieldView(vBox, "Опис:", Опис, 1400, 100);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
            // Таблична частина "ЗвітСторінка"
            ЗвітСторінка.WidthRequest = 500;
            ЗвітСторінка.HeightRequest = 300;
            CreateTablePart(vBox, "Звіт", ЗвітСторінка);
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        
        if (IsNew) 
            Елемент.Користувач = ВласникДляНового;
        Додано.Value = Елемент.Додано;
                Назва.SetText(Елемент.Назва);
                        Опис.Buffer?.Text = Елемент.Опис;
                        
            // Таблична частина "ЗвітСторінка"
            ЗвітСторінка.ЕлементВласник = Елемент;
            await ЗвітСторінка.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.Додано = Додано.Value;
                Елемент.Назва = Назва.GetText();
                        Елемент.Опис = Опис.Buffer?.Text ?? "";
                        
    }

    #endregion

    protected override async ValueTask<bool> Save()
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
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    