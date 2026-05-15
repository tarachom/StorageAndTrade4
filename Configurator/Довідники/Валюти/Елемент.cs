
/*
        Валюти_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_3FY3TJMbG0y9WEVZR5UM0Q")]
partial class Валюти_Елемент : DirectoryFormElement
{
    public Валюти_Objest Елемент { get; init; } = new();
    
    #region Fields
    Entry Код = Entry.New();
                    Entry Назва = Entry.New();
                    Entry КороткаНазва = Entry.New();
                    Entry Код_R030 = Entry.New();
                    CheckButton ВиводитиКурсНаСтартову = CheckButton.NewWithLabel("ВиводитиКурсНаСтартову");
            
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
                        
            // КороткаНазва:
            КороткаНазва.WidthRequest = 300;
                        
            // Код_R030:
            Код_R030.WidthRequest = 300;
                        
            // ВиводитиКурсНаСтартову:
            
    }

    public static Валюти_Елемент New()
    {
        Валюти_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
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
            ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    