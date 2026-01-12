
/*
        ПакуванняОдиниціВиміру_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class ПакуванняОдиниціВиміру_Елемент : DirectoryFormElement
{
    public ПакуванняОдиниціВиміру_Objest Елемент { get; init; } = new ПакуванняОдиниціВиміру_Objest();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    Entry Код = new() { WidthRequest = 500 };
                    Entry НазваПовна = new() { WidthRequest = 500 };
                    IntegerControl КількістьУпаковок = new();
            
    #endregion

    #region TabularParts
    
    #endregion

    public ПакуванняОдиниціВиміру_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // НазваПовна
            CreateField(vBox, "НазваПовна:", НазваПовна);
                        
            // КількістьУпаковок
            CreateField(vBox, "КількістьУпаковок:", КількістьУпаковок);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override  async ValueTask AssignValue()
    {
        Назва.SetText(Елемент.Назва);
                        Код.SetText(Елемент.Код);
                        НазваПовна.SetText(Елемент.НазваПовна);
                        КількістьУпаковок.Value = Елемент.КількістьУпаковок;
               
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Код = Код.GetText();
                        Елемент.НазваПовна = НазваПовна.GetText();
                        Елемент.КількістьУпаковок = КількістьУпаковок.Value;
                
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
    