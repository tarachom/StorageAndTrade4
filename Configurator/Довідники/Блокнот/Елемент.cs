
/*
        Блокнот_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_u9GQEi2OAkqBqfQldvkYeA")]
partial class Блокнот_Елемент : DirectoryFormElement
{
    public Блокнот_Objest Елемент { get; init; } = new();
    
    #region Fields
    Entry Код = Entry.New();
                    Entry Назва = Entry.New();
                    DateTimeControl ДатаЗапису = DateTimeControl.New();
            TextView Опис = TextView.New();
                    Entry Лінк = Entry.New();
                    
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
                        
            // ДатаЗапису:
            
            // Опис:
            Опис.WrapMode = WrapMode.Word;
                        
            // Лінк:
            Лінк.WidthRequest = 300;
                        
    }

    public static Блокнот_Елемент New()
    {
        Блокнот_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // ДатаЗапису
            CreateField(vBox, "Дата запису:", ДатаЗапису);
                        
            // Опис
            CreateFieldView(vBox, "Опис:", Опис, 500, 200);
                        
            // Лінк
            CreateField(vBox, "Лінк:", Лінк);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        ДатаЗапису.Value = Елемент.ДатаЗапису;
                Опис.Buffer?.Text = Елемент.Опис;
                        Лінк.SetText(Елемент.Лінк);
                        
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.ДатаЗапису = ДатаЗапису.Value;
                Елемент.Опис = Опис.Buffer?.Text ?? "";
                        Елемент.Лінк = Лінк.GetText();
                        
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
    