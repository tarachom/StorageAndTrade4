
/*
        Блокнот_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Блокнот_Елемент : DirectoryFormElement
{
    public Блокнот_Objest Елемент { get; init; } = new Блокнот_Objest();
    
    #region Fields
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 500 };
                    DateTimeControl ДатаЗапису = new();
            TextView Опис = new TextView() { WrapMode = WrapMode.Word };
                    Entry Лінк = new() { WidthRequest = 500 };
                    
    #endregion

    #region TabularParts
    
    #endregion

    public Блокнот_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
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
    