
/*
        СтруктураПідприємства_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class СтруктураПідприємства_Елемент : DirectoryFormElement
{
    public СтруктураПідприємства_Objest Елемент { get; init; } = new СтруктураПідприємства_Objest();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    Entry Код = new() { WidthRequest = 500 };
                    ФізичніОсоби_PointerControl Керівник = new() { Caption = "Керівник", WidthPresentation = 500 };
            
    #endregion

    #region TabularParts
    
    #endregion

    public СтруктураПідприємства_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Керівник
            CreateField(vBox, null, Керівник);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Назва.SetText(Елемент.Назва);
                        Код.SetText(Елемент.Код);
                        Керівник.Pointer = Елемент.Керівник;
                
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Код = Код.GetText();
                        Елемент.Керівник = Керівник.Pointer;
                
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
    