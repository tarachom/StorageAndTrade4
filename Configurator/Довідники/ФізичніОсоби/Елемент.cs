
/*
        ФізичніОсоби_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class ФізичніОсоби_Елемент : DirectoryFormElement
{
    public ФізичніОсоби_Objest Елемент { get; init; } = new ФізичніОсоби_Objest();
    
    #region Fields
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 500 };
                    DateTimeControl ДатаНародження = new(){ OnlyDate = true };
            ComboBoxText Стать = new ComboBoxText();
            Entry ІПН = new() { WidthRequest = 200 };
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Контакти"
        ФізичніОсоби_ТабличнаЧастина_Контакти Контакти = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public ФізичніОсоби_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СтатьФізичноїОсоби_List())
                Стать.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            Стать.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // ДатаНародження
            CreateField(vBox, "Дата народження:", ДатаНародження);
                        
            // Стать
            CreateField(vBox, "Стать:", Стать);
                
            // ІПН
            CreateField(vBox, "ІПН:", ІПН);
                        
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
                        ДатаНародження.Value = Елемент.ДатаНародження;
                Стать.ActiveId = Елемент.Стать.ToString();
                ІПН.SetText(Елемент.ІПН);
                        
            // Таблична частина "Контакти"
            Контакти.ЕлементВласник = Елемент;
            await Контакти.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.ДатаНародження = ДатаНародження.Value;
                Елемент.Стать = ПсевдонімиПерелічення.СтатьФізичноїОсоби_FindByName(Стать.ActiveId);
                Елемент.ІПН = ІПН.GetText();
                        
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
        catch 
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    