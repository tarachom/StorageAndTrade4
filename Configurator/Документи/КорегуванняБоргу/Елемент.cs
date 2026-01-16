
/*
        КорегуванняБоргу_Елемент.cs
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
using Функції = StorageAndTrade.КорегуванняБоргу_Функції;

namespace StorageAndTrade;

class КорегуванняБоргу_Елемент : DocumentFormElement
{
    public КорегуванняБоргу_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new() { WidthRequest = 100 };
                    DateTimeControl ДатаДок = new();
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 300 };
            Entry Коментар = new() { WidthRequest = 300 };
                    CompositePointerControl Основа = new() { BoundConfType = "Документи.КорегуванняБоргу.Основа" };
            
    #endregion

    #region TabularParts
    
        // Таблична частина "РозрахункиЗКонтрагентами" 
        КорегуванняБоргу_ТабличнаЧастина_РозрахункиЗКонтрагентами РозрахункиЗКонтрагентами = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public КорегуванняБоргу_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(КорегуванняБоргу_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "РозрахункиЗКонтрагентами" 
            NotebookTablePart.InsertPage(РозрахункиЗКонтрагентами, Label.New("Розрахунки з контрагентами"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
    }

    protected override void CreateTopStart(Box vBox)
    {
        
    }

    protected override void CreateTopEnd(Box vBox)
    {
        
    }

    protected override void CreateBottomStart(Box vBox)
    {
        
            // Організація
            CreateField(vBox, null, Організація);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Основа
            CreateField(vBox, null, Основа);
                
    }

    protected override void CreateBottomEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        НомерДок.SetText(Елемент.НомерДок);
                        ДатаДок.Value = Елемент.ДатаДок;
                Організація.Pointer = Елемент.Організація;
                Підрозділ.Pointer = Елемент.Підрозділ;
                Коментар.SetText(Елемент.Коментар);
                        Основа.Pointer = Елемент.Основа;
                
            // Таблична частина "РозрахункиЗКонтрагентами" 
            РозрахункиЗКонтрагентами.ЕлементВласник = Елемент; 
            await РозрахункиЗКонтрагентами.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
                        Елемент.ДатаДок = ДатаДок.Value;
                Елемент.Організація = Організація.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Основа = Основа.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Підрозділ.Pointer.Назва}"
         + РозрахункиЗКонтрагентами.КлючовіСловаДляПошуку();
    }*/
    

    #endregion
    
    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if(await Елемент.Save())
            {
                await РозрахункиЗКонтрагентами.SaveRecords(); // Таблична частина "РозрахункиЗКонтрагентами"
                
                isSaved = true;
            }
        }
        catch (Exception ex)
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }

    protected override async ValueTask<bool> SpendTheDocument(bool spendDoc)
    {
        if (spendDoc)
        {
            bool isSpend = await Елемент.SpendTheDocument(Елемент.ДатаДок);
            //if (!isSpend) ФункціїДляПовідомлень.ПоказатиПовідомлення(Елемент.UnigueID);
            return isSpend;
        }
        else
        {
            await Елемент.ClearSpendTheDocument();
            return true;
        }
    }

    protected override void ReportSpendTheDocument(UnigueID unigueID)
    {
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new КорегуванняБоргу_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
    