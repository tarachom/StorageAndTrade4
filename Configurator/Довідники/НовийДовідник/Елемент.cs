
/*
        НовийДовідник_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("NovyiDovidnyk_Element")]
partial class НовийДовідник_Елемент : DirectoryFormElement
{
    public НовийДовідник_Object Елемент { get; init; } = new();
    
    #region Fields
    Entry Код = Entry.New();
                    Entry Назва = Entry.New();
                    
    #endregion

    #region TabularParts
    
    #endregion

    partial void Initialize()
    { 
        Element = Елемент;

        
            // Код:
            Код.WidthRequest = 300;
                        
            // Назва:
            Назва.WidthRequest = 300;
                        
    }

    public static НовийДовідник_Елемент New()
    {
        НовийДовідник_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DirectoryElement Interface = FunctionForInterfaces.ForDirectory();

    protected override void BuildInterface()
    {
        Append(Interface.MainBox);
        CreateStart(Interface.TopStartBox);
        CreateEnd(Interface.TopEndBox);
    }

    void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
    }

    void CreateEnd(Box vBox)
    {
        
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        
    }

    #endregion

    protected override async Task<bool> Save()
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
    