
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
    Entry Назва = new() { WidthRequest = 500 };
                    Entry Код = new() { WidthRequest = 500 };
                    ФізичніОсоби_PointerControl ФізичнаОсоба = new() { Caption = "ФізичнаОсоба", WidthPresentation = 500 };
            Entry Коментар = new() { WidthRequest = 500 };
                    //Guid КодВСпеціальнійТаблиці = new();
            
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
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // ФізичнаОсоба
            CreateField(vBox, null, ФізичнаОсоба);
                
            // Коментар
            CreateField(vBox, "Коментар:", Коментар);
                        
            // КодВСпеціальнійТаблиці
    }

    protected override void CreateEnd(Box vBox)
    {
        
            // Таблична частина "Контакти" 
            CreateTablePart(vBox, "Контакти:", Контакти);
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Назва.SetText(Елемент.Назва);
                        Код.SetText(Елемент.Код);
                        ФізичнаОсоба.Pointer = Елемент.ФізичнаОсоба;
                Коментар.SetText(Елемент.Коментар);
                        //КодВСпеціальнійТаблиці = Елемент.КодВСпеціальнійТаблиці;
                
            // Таблична частина "Контакти"
            Контакти.ЕлементВласник = Елемент;
            await Контакти.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Код = Код.GetText();
                        Елемент.ФізичнаОсоба = ФізичнаОсоба.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        //Елемент.КодВСпеціальнійТаблиці = КодВСпеціальнійТаблиці;
                
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
    