
/*
        Номенклатура_Папки_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_ZbpESiTL2k2KKUuuppiA")]
partial class Номенклатура_Папки_Елемент : DirectoryFormElement
{
    public Номенклатура_Папки_Objest Елемент { get; init; } = new();
    
    public Номенклатура_Папки_Pointer РодичДляНового { get; set; } = new();
    
    #region Fields
    Entry Код = Entry.New();
                    Entry Назва = Entry.New();
                    Номенклатура_Папки_PointerControl Родич = Номенклатура_Папки_PointerControl.New();
            
    #endregion

    #region TabularParts
    
    #endregion

    partial void Initialize()
    { 
        Element = Елемент;

        
            // Код:
            Код.WidthRequest = 100;
                        
            // Назва:
            Назва.WidthRequest = 300;
                        
            // Родич:
            Родич.Caption = "Папка";
                    Родич.WidthPresentation = 300;
                
    }

    public static Номенклатура_Папки_Елемент New()
    {
        Номенклатура_Папки_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
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
    