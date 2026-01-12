
/*
        БанківськіРахункиКонтрагентів_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class БанківськіРахункиКонтрагентів_Елемент : DirectoryFormElement
{
    public БанківськіРахункиКонтрагентів_Objest Елемент { get; init; } = new БанківськіРахункиКонтрагентів_Objest();
    
    #region Fields
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 500 };
                    Банки_PointerControl Банк = new() { Caption = "Банк", WidthPresentation = 500 };
            Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 500 };
            Entry НомерРахунку = new() { WidthRequest = 500 };
                    Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
            
    #endregion

    #region TabularParts
    
    #endregion

    public БанківськіРахункиКонтрагентів_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Банк
            CreateField(vBox, null, Банк);
                
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
            // НомерРахунку
            CreateField(vBox, "Номер рахунку:", НомерРахунку);
                        
            // Валюта
            CreateField(vBox, null, Валюта);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        Банк.Pointer = Елемент.Банк;
                Контрагент.Pointer = Елемент.Контрагент;
                НомерРахунку.SetText(Елемент.НомерРахунку);
                        Валюта.Pointer = Елемент.Валюта;
                
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.Банк = Банк.Pointer;
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.НомерРахунку = НомерРахунку.GetText();
                        Елемент.Валюта = Валюта.Pointer;
                
    }

    #endregion

    protected override async ValueTask<bool> Save()
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
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    