
/*
        Організації_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Організації_Елемент : DirectoryFormElement
{
    public Організації_Objest Елемент { get; init; } = new();
    
    #region Fields
    Entry Код = Entry.New();
                    Entry Назва = Entry.New();
                    Entry НазваПовна = Entry.New();
                    Entry НазваСкорочена = Entry.New();
                    DateTimeControl ДатаРеєстрації = DateTimeControl.New();
            Entry КраїнаРеєстрації = Entry.New();
                    Entry СвідоцтвоСеріяНомер = Entry.New();
                    Entry СвідоцтвоДатаВидачі = Entry.New();
                    Організації_PointerControl Холдинг = Організації_PointerControl.New();
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Контакти"
        Організації_ТабличнаЧастина_Контакти Контакти = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public Організації_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;

        Код.WidthRequest = 100;
                        Назва.WidthRequest = 300;
                        НазваПовна.WidthRequest = 300;
                        НазваСкорочена.WidthRequest = 300;
                        ДатаРеєстрації.OnlyDate = true;
                КраїнаРеєстрації.WidthRequest = 300;
                        СвідоцтвоСеріяНомер.WidthRequest = 200;
                        СвідоцтвоДатаВидачі.WidthRequest = 200;
                        Холдинг.Caption = "Холдинг";
                    Холдинг.WidthPresentation = 300;
                
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // НазваПовна
            CreateField(vBox, "Назва повна:", НазваПовна);
                        
            // НазваСкорочена
            CreateField(vBox, "Назва скорочена:", НазваСкорочена);
                        
            // ДатаРеєстрації
            CreateField(vBox, "Дата реєстрації:", ДатаРеєстрації);
                        
            // КраїнаРеєстрації
            CreateField(vBox, "Країна реєстрації:", КраїнаРеєстрації);
                        
            // СвідоцтвоСеріяНомер
            CreateField(vBox, "Свідоцтво серія номер:", СвідоцтвоСеріяНомер);
                        
            // СвідоцтвоДатаВидачі
            CreateField(vBox, "Свідоцтво дата видачі:", СвідоцтвоДатаВидачі);
                        
            // Холдинг
            CreateField(vBox, null, Холдинг);
                
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
                        НазваПовна.SetText(Елемент.НазваПовна);
                        НазваСкорочена.SetText(Елемент.НазваСкорочена);
                        ДатаРеєстрації.Value = Елемент.ДатаРеєстрації;
                КраїнаРеєстрації.SetText(Елемент.КраїнаРеєстрації);
                        СвідоцтвоСеріяНомер.SetText(Елемент.СвідоцтвоСеріяНомер);
                        СвідоцтвоДатаВидачі.SetText(Елемент.СвідоцтвоДатаВидачі);
                        Холдинг.Pointer = Елемент.Холдинг;
                
            // Таблична частина "Контакти"
            Контакти.ЕлементВласник = Елемент;
            await Контакти.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.НазваПовна = НазваПовна.GetText();
                        Елемент.НазваСкорочена = НазваСкорочена.GetText();
                        Елемент.ДатаРеєстрації = ДатаРеєстрації.Value;
                Елемент.КраїнаРеєстрації = КраїнаРеєстрації.GetText();
                        Елемент.СвідоцтвоСеріяНомер = СвідоцтвоСеріяНомер.GetText();
                        Елемент.СвідоцтвоДатаВидачі = СвідоцтвоДатаВидачі.GetText();
                        Елемент.Холдинг = Холдинг.Pointer;
                
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
    