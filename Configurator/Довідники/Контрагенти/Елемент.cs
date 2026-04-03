
/*
        Контрагенти_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Контрагенти_Елемент : DirectoryFormElement
{
    public Контрагенти_Objest Елемент { get; init; } = new();
    
    #region Fields
    Entry Код = Entry.New();
                    Entry Назва = Entry.New();
                    Entry НазваПовна = Entry.New();
                    Entry РеєстраційнийНомер = Entry.New();
                    Контрагенти_Папки_PointerControl Папка = Контрагенти_Папки_PointerControl.New();
            Entry Опис = Entry.New();
                    CheckButton Постачальник = CheckButton.NewWithLabel("Постачальник");
            CheckButton Покупець = CheckButton.NewWithLabel("Покупець");
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Контакти"
        Контрагенти_ТабличнаЧастина_Контакти Контакти = new() { WidthRequest = 500, HeightRequest = 300 };
    
        // Таблична частина "Файли"
        Контрагенти_ТабличнаЧастина_Файли Файли = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public Контрагенти_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;

        Код.WidthRequest = 100;
                        Назва.WidthRequest = 300;
                        НазваПовна.WidthRequest = 300;
                        РеєстраційнийНомер.WidthRequest = 300;
                        Папка.Caption = "Папка";
                    Папка.WidthPresentation = 300;
                Опис.WidthRequest = 300;
                        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // НазваПовна
            CreateField(vBox, "Повна назва:", НазваПовна);
                        
            // РеєстраційнийНомер
            CreateField(vBox, "Реєстраційний номер:", РеєстраційнийНомер);
                        
            // Папка
            CreateField(vBox, null, Папка);
                
            // Опис
            CreateField(vBox, "Опис:", Опис);
                        
            // Постачальник
            CreateField(vBox, null, Постачальник);
                
            // Покупець
            CreateField(vBox, null, Покупець);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
            // Таблична частина "Контакти" 
            CreateTablePart(vBox, "Контакти:", Контакти);
        
            // Таблична частина "Файли" 
            CreateTablePart(vBox, "Файли:", Файли);
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        НазваПовна.SetText(Елемент.НазваПовна);
                        РеєстраційнийНомер.SetText(Елемент.РеєстраційнийНомер);
                        Папка.Pointer = Елемент.Папка;
                Опис.SetText(Елемент.Опис);
                        Постачальник.Active = Елемент.Постачальник;
                Покупець.Active = Елемент.Покупець;
                
            // Таблична частина "Контакти"
            Контакти.ЕлементВласник = Елемент;
            await Контакти.LoadRecords();
        
            // Таблична частина "Файли"
            Файли.ЕлементВласник = Елемент;
            await Файли.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.НазваПовна = НазваПовна.GetText();
                        Елемент.РеєстраційнийНомер = РеєстраційнийНомер.GetText();
                        Елемент.Папка = Папка.Pointer;
                Елемент.Опис = Опис.GetText();
                        Елемент.Постачальник = Постачальник.Active;
                Елемент.Покупець = Покупець.Active;
                
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
                await Файли.SaveRecords(); // Таблична частина "Файли"
                
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
    