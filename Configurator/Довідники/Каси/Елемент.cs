
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
    public Каси_Objest Елемент { get; init; } = new();
    
    #region Fields
    Entry Код = Entry.New();
                    Entry Назва = Entry.New();
                    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            
    #endregion

    #region TabularParts
    
    #endregion

    public Каси_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;

        Код.WidthRequest = 100;
                        Назва.WidthRequest = 300;
                        Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
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
                        Валюта.Pointer = Елемент.Валюта;
                Підрозділ.Pointer = Елемент.Підрозділ;
                
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
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
    