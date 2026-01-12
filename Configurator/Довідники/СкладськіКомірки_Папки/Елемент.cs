
/*
        СкладськіКомірки_Папки_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class СкладськіКомірки_Папки_Елемент : DirectoryFormElement
{
    public СкладськіКомірки_Папки_Objest Елемент { get; init; } = new СкладськіКомірки_Папки_Objest();
    
    public СкладськіПриміщення_Pointer ВласникДляНового = new СкладськіПриміщення_Pointer();
    
    public СкладськіКомірки_Папки_Pointer РодичДляНового { get; set; } = new СкладськіКомірки_Папки_Pointer();
    
    #region Fields
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 500 };
                    СкладськіКомірки_Папки_PointerControl Родич = new() { Caption = "Папка", WidthPresentation = 500 };
            СкладськіПриміщення_PointerControl Власник = new() { Caption = "Приміщення", WidthPresentation = 500 };
            
    #endregion

    #region TabularParts
    
    #endregion

    public СкладськіКомірки_Папки_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Родич
            CreateField(vBox, null, Родич);
                
            // Власник
            CreateField(vBox, null, Власник);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        
        if (IsNew) 
            Елемент.Власник = ВласникДляНового;
        
                if (IsNew)
                    Елемент.Родич = РодичДляНового;
                else
                    Родич.OpenFolder = Елемент.UnigueID;
            Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        Родич.Pointer = Елемент.Родич;
                Власник.Pointer = Елемент.Власник;
                
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.Родич = Родич.Pointer;
                Елемент.Власник = Власник.Pointer;
                
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
    