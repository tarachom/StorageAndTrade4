
/*
        СеріїНоменклатури_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class СеріїНоменклатури_Елемент : DirectoryFormElement
{
    public СеріїНоменклатури_Objest Елемент { get; init; } = new СеріїНоменклатури_Objest();
    
    #region Fields
    Entry Номер = new() { WidthRequest = 500 };
                    Entry Коментар = new() { WidthRequest = 500 };
                    DateTimeControl ДатаСтворення = new();
            
    #endregion

    #region TabularParts
    
    #endregion

    public СеріїНоменклатури_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Номер
            CreateField(vBox, "Номер:", Номер);
                        
            // Коментар
            CreateField(vBox, "Коментар:", Коментар);
                        
            // ДатаСтворення
            CreateField(vBox, "ДатаСтворення:", ДатаСтворення);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override  async ValueTask AssignValue()
    {
        Номер.SetText(Елемент.Номер);
                        Коментар.SetText(Елемент.Коментар);
                        ДатаСтворення.Value = Елемент.ДатаСтворення;
                
    }

    protected override void GetValue()
    {
        Елемент.Номер = Номер.GetText();
                        Елемент.Коментар = Коментар.GetText();
                        Елемент.ДатаСтворення = ДатаСтворення.Value;
                
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
    