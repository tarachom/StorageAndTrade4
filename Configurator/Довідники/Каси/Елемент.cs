
/*
        Каси_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Каси_Елемент : DirectoryFormElement
{
    public Каси_Objest Елемент { get; init; } = new Каси_Objest();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    Entry Код = new() { WidthRequest = 500 };
                    Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 500 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 500 };
            
    #endregion

    #region TabularParts
    
    #endregion

    public Каси_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Код
            CreateField(vBox, "Код:", Код);
                        
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
        Назва.SetText(Елемент.Назва);
                        Код.SetText(Елемент.Код);
                        Валюта.Pointer = Елемент.Валюта;
                Підрозділ.Pointer = Елемент.Підрозділ;
                
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Код = Код.GetText();
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
        catch (Exception ex)
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    