
/*
        Контрагенти_Папки_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Контрагенти_Папки_Елемент : DirectoryFormElement
{
    public Контрагенти_Папки_Objest Елемент { get; init; } = new Контрагенти_Папки_Objest();
    
    public Контрагенти_Папки_Pointer РодичДляНового { get; set; } = new Контрагенти_Папки_Pointer();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    Entry Код = new() { WidthRequest = 500 };
                    Контрагенти_Папки_PointerControl Родич = new() { Caption = "Родич", WidthPresentation = 500 };
            
    #endregion

    #region TabularParts
    
    #endregion

    public Контрагенти_Папки_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Родич
            CreateField(vBox, null, Родич);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        
                if (IsNew)
                    Елемент.Родич = РодичДляНового;
                else
                    Родич.OpenFolder = Елемент.UnigueID;
            Назва.SetText(Елемент.Назва);
                        Код.SetText(Елемент.Код);
                        Родич.Pointer = Елемент.Родич;
                
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Код = Код.GetText();
                        Елемент.Родич = Родич.Pointer;
                
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
    