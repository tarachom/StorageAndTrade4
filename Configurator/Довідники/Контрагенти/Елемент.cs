
/*
        Контрагенти_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_jMqhqihMkKNPwAvNR6L7w")]
partial class Контрагенти_Елемент : DirectoryFormElement
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
        Контрагенти_ТабличнаЧастина_Контакти Контакти = Контрагенти_ТабличнаЧастина_Контакти.New();
    
        // Таблична частина "Файли"
        Контрагенти_ТабличнаЧастина_Файли Файли = Контрагенти_ТабличнаЧастина_Файли.New();
    
    #endregion

    partial void Initialize()
    { 
        Element = Елемент;

        
            // Код:
            Код.WidthRequest = 100;
                        
            // Назва:
            Назва.WidthRequest = 300;
                        
            // НазваПовна:
            НазваПовна.WidthRequest = 300;
                        
            // РеєстраційнийНомер:
            РеєстраційнийНомер.WidthRequest = 300;
                        
            // Папка:
            Папка.Caption = "Папка";
                    Папка.WidthPresentation = 300;
                
            // Опис:
            Опис.WidthRequest = 300;
                        
            // Постачальник:
            
            // Покупець:
            
    }

    public static Контрагенти_Елемент New()
    {
        Контрагенти_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
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
            Контакти.WidthRequest = 500;
            Контакти.HeightRequest = 300;
            CreateTablePart(vBox, "Контакти", Контакти);
        
            // Таблична частина "Файли"
            Файли.WidthRequest = 500;
            Файли.HeightRequest = 300;
            CreateTablePart(vBox, "Файли", Файли);
        
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
            ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    