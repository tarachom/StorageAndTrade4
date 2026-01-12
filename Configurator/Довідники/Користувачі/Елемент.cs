
/*
        Користувачі_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Користувачі_Елемент : DirectoryFormElement
{
    public Користувачі_Objest Елемент { get; init; } = new Користувачі_Objest();
    
    #region Fields
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 500 };
                    ФізичніОсоби_PointerControl ФізичнаОсоба = new() { Caption = "Фізична особа", WidthPresentation = 500 };
            Entry Коментар = new() { WidthRequest = 500 };
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Контакти"
        Користувачі_ТабличнаЧастина_Контакти Контакти = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public Користувачі_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // ФізичнаОсоба
            CreateField(vBox, null, ФізичнаОсоба);
                
            // Коментар
            CreateField(vBox, "Коментар:", Коментар);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
            // Таблична частина "Контакти" 
            CreateTablePart(vBox, "Контакти:", Контакти);
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        ФізичнаОсоба.Pointer = Елемент.ФізичнаОсоба;
                Коментар.SetText(Елемент.Коментар);
                        
            // Таблична частина "Контакти"
            Контакти.ЕлементВласник = Елемент;
            await Контакти.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.ФізичнаОсоба = ФізичнаОсоба.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        
    }

    #endregion

    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await Контакти.SaveRecords(); // Таблична частина "Контакти"
                
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
    