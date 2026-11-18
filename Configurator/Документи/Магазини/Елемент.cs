
/*
        Магазини_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode;
using GeneratedCode.Константи;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.Магазини_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Mahazyny_Element")]
partial class Магазини_Елемент : DocumentFormElement
{
    public Магазини_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Entry Коментар = Entry.New();
                    CompositePointerControl Підстава = CompositePointerControl.New();
            DropDownControl Тип = DropDownControl.New();
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        Магазини_ТабличнаЧастина_Товари Товари = Магазини_ТабличнаЧастина_Товари.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(Магазини_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(Interface.CommentBox, "Коментар:", Коментар);
        
            // Таблична частина "Товари"
            Товари.ЕлементВласник = Елемент;
            Товари.HeightRequest = 300;
            Interface.Notebook.InsertPage(Товари, Label.New("Товари"), 0);
            
            Interface.Notebook.SetCurrentPage(0);
        
            //НомерДок:
            НомерДок.WidthRequest = 300;
                        
            //ДатаДок:
            
            //Коментар:
            Коментар.WidthRequest = 300;
                        
            //Підстава:
            Підстава.BoundConfType = "Документи.Магазини.Підстава";
                
            //Тип:
            Тип.Fill(ПсевдонімиПерелічення.ТипДокументу_Dict());
                
    }

    public static Магазини_Елемент New()
    {
        Магазини_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DocumentElement Interface = FunctionForInterfaces.ForDocument();

    protected override void BuildInterface()
    {
        Append(Interface.MainBox);

        CreateTopStart(Interface.TopStartBox);
        CreateTopEnd(Interface.TopEndBox);
        CreateBottomStart(Interface.BottomStartBox);
        CreateBottomEnd(Interface.BottomEndBox);
    }

    void CreateTopStart(Box vBox)
    {
        // Тип
            CreateField(vBox, "Тип:", Тип);
    }

    void CreateTopEnd(Box vBox)
    {
        
    }

    void CreateBottomStart(Box vBox)
    {
        
            // Підстава
            CreateField(vBox, null, Підстава);
                
            
                
    }

    void CreateBottomEnd(Box vBox)
    {
        
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        НомерДок.SetText(Елемент.НомерДок);
                        ДатаДок.Value = Елемент.ДатаДок;
                Коментар.SetText(Елемент.Коментар);
                        Підстава.Pointer = Елемент.Підстава;
                Тип.Value = Елемент.Тип.ToString();
                await Товари.LoadRecords();  // Таблична частина "Товари" 
        
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
                        Елемент.ДатаДок = ДатаДок.Value;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Підстава = Підстава.Pointer;
                Елемент.Тип = ПсевдонімиПерелічення.ТипДокументу_FindByName(Тип.Value);
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n"
         + Товари.КлючовіСловаДляПошуку();
    }*/
    

    #endregion
    
    protected override async Task<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if(await Елемент.Save())
            {
                await Товари.SaveRecords(); // Таблична частина "Товари"
                
                isSaved = true;
            }
        }
        catch (Exception ex)
        {
            ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }

    protected override async Task<bool> SpendTheDocument(bool spendDoc)
    {
        if (spendDoc)
        {
            bool isSpend = await Елемент.SpendTheDocument(Елемент.ДатаДок);
            if (!isSpend) ФункціїДляПовідомлень.ПоказатиПовідомлення(Елемент.UniqueID);
            return isSpend;
        }
        else
        {
            await Елемент.ClearSpendTheDocument();
            return true;
        }
    }

    protected override void ReportSpendTheDocument(UniqueID uniqueID)
    {
        CommonForms_DocumentMovementThroughRegisters.Create(new Магазини_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    