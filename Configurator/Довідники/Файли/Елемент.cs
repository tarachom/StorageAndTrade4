
/*
        Файли_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Файли_Елемент : DirectoryFormElement
{
    public Файли_Objest Елемент { get; init; } = new Файли_Objest();
    
    #region Fields
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 500 };
                    Entry НазваФайлу = new() { WidthRequest = 500 };
                    Entry Розмір = new() { WidthRequest = 500 };
                    DateTimeControl ДатаСтворення = new();
            
    #endregion

    #region TabularParts
    
    #endregion

    public Файли_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // НазваФайлу
            CreateField(vBox, "Назва файлу:", НазваФайлу);
                        
            // Розмір
            CreateField(vBox, "Розмір:", Розмір);
                        
            // ДатаСтворення
            CreateField(vBox, "Дата створення:", ДатаСтворення);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        НазваФайлу.SetText(Елемент.НазваФайлу);
                        Розмір.SetText(Елемент.Розмір);
                        ДатаСтворення.Value = Елемент.ДатаСтворення;
                
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.НазваФайлу = НазваФайлу.GetText();
                        Елемент.Розмір = Розмір.GetText();
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
        catch (Exception ex)
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    