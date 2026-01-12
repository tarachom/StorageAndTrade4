
/*
        Валюти_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Валюти_Елемент : DirectoryFormElement
{
    public Валюти_Objest Елемент { get; init; } = new Валюти_Objest();
    
    #region Fields
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 500 };
                    Entry КороткаНазва = new() { WidthRequest = 500 };
                    Entry Код_R030 = new() { WidthRequest = 500 };
                    CheckButton ВиводитиКурсНаСтартову = CheckButton.NewWithLabel("ВиводитиКурсНаСтартову");
            
    #endregion

    #region TabularParts
    
    #endregion

    public Валюти_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // КороткаНазва
            CreateField(vBox, "Коротка назва:", КороткаНазва);
                        
            // Код_R030
            CreateField(vBox, "Код R030:", Код_R030);
                        
            // ВиводитиКурсНаСтартову
            CreateField(vBox, null, ВиводитиКурсНаСтартову);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        КороткаНазва.SetText(Елемент.КороткаНазва);
                        Код_R030.SetText(Елемент.Код_R030);
                        ВиводитиКурсНаСтартову.Active = Елемент.ВиводитиКурсНаСтартову;
                
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.КороткаНазва = КороткаНазва.GetText();
                        Елемент.Код_R030 = Код_R030.GetText();
                        Елемент.ВиводитиКурсНаСтартову = ВиводитиКурсНаСтартову.Active;
                
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
    