
/*
        ЗбереженіЗвіти_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class ЗбереженіЗвіти_Елемент : DirectoryFormElement
{
    public ЗбереженіЗвіти_Objest Елемент { get; init; } = new ЗбереженіЗвіти_Objest();
    
    public Користувачі_Pointer ВласникДляНового = new Користувачі_Pointer();
    
    #region Fields
    DateTimeControl Додано = new();
            Entry Назва = new() { WidthRequest = 500 };
                    TextView Опис = new TextView() { WrapMode = WrapMode.Word };
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "ЗвітСторінка"
        ЗбереженіЗвіти_ТабличнаЧастина_ЗвітСторінка ЗвітСторінка = new() { WidthRequest = 1500, HeightRequest = 600 };
    
    #endregion

    public ЗбереженіЗвіти_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
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
            CreateTablePart(vBox, "Звіт:", ЗвітСторінка);
        
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
    