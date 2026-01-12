
/*
        БанківськіРахункиОрганізацій_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class БанківськіРахункиОрганізацій_Елемент : DirectoryFormElement
{
    public БанківськіРахункиОрганізацій_Objest Елемент { get; init; } = new БанківськіРахункиОрганізацій_Objest();
    
    #region Fields
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 500 };
                    Банки_PointerControl Банк = new() { Caption = "Банк", WidthPresentation = 500 };
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 500 };
            Entry НомерРахунку = new() { WidthRequest = 500 };
                    Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 500 };
            
    #endregion

    #region TabularParts
    
    #endregion

    public БанківськіРахункиОрганізацій_Елемент() : base(Program.BasicForm?.NotebookFunc)
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
                
            // Організація
            CreateField(vBox, null, Організація);
                
            // НомерРахунку
            CreateField(vBox, "Номер рахунку:", НомерРахунку);
                        
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
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
                Організація.Pointer = Елемент.Організація;
                НомерРахунку.SetText(Елемент.НомерРахунку);
                        Валюта.Pointer = Елемент.Валюта;
                Підрозділ.Pointer = Елемент.Підрозділ;
                
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.Банк = Банк.Pointer;
                Елемент.Організація = Організація.Pointer;
                Елемент.НомерРахунку = НомерРахунку.GetText();
                        Елемент.Валюта = Валюта.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                
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
        catch 
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    