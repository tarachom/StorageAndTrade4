
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
    public Контрагенти_Папки_Objest Елемент { get; init; } = new();
    
    public Контрагенти_Папки_Pointer РодичДляНового { get; set; } = new();
    
    #region Fields
    Entry Код = Entry.New();
                    Entry Назва = Entry.New();
                    Контрагенти_Папки_PointerControl Родич = Контрагенти_Папки_PointerControl.New();
            
    #endregion

    #region TabularParts
    
    #endregion

    public Контрагенти_Папки_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;

        Код.WidthRequest = 100;
                        Назва.WidthRequest = 300;
                        Родич.Caption = "Родич";
                    Родич.WidthPresentation = 300;
                
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
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
                    Родич.OpenFolder = Елемент.UniqueID;
            Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        Родич.Pointer = Елемент.Родич;
                
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
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
    