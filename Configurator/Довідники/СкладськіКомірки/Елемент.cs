
/*
        СкладськіКомірки_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class СкладськіКомірки_Елемент : DirectoryFormElement
{
    public СкладськіКомірки_Objest Елемент { get; init; } = new СкладськіКомірки_Objest();
    
    public СкладськіПриміщення_Pointer ВласникДляНового = new СкладськіПриміщення_Pointer();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    СкладськіПриміщення_PointerControl Приміщення = new() { Caption = "Приміщення", WidthPresentation = 500 };
            СкладськіКомірки_Папки_PointerControl Папка = new() { Caption = "Папка", WidthPresentation = 500 };
            Entry Лінія = new() { WidthRequest = 500 };
                    Entry Позиція = new() { WidthRequest = 500 };
                    Entry Стелаж = new() { WidthRequest = 500 };
                    Entry Ярус = new() { WidthRequest = 500 };
                    ComboBoxText ТипСкладськоїКомірки = new ComboBoxText();
            ТипорозміриКомірок_PointerControl Типорозмір = new() { Caption = "Типорозмір", WidthPresentation = 500 };
            
    #endregion

    #region TabularParts
    
    #endregion

    public СкладськіКомірки_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипиСкладськихКомірок_List())
                ТипСкладськоїКомірки.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ТипСкладськоїКомірки.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Приміщення
            CreateField(vBox, null, Приміщення);
                
            // Папка
            CreateField(vBox, null, Папка);
                
            // Лінія
            CreateField(vBox, "Лінія:", Лінія);
                        
            // Позиція
            CreateField(vBox, "Позиція:", Позиція);
                        
            // Стелаж
            CreateField(vBox, "Стелаж:", Стелаж);
                        
            // Ярус
            CreateField(vBox, "Ярус:", Ярус);
                        
            // ТипСкладськоїКомірки
            CreateField(vBox, "Тип:", ТипСкладськоїКомірки);
                
            // Типорозмір
            CreateField(vBox, null, Типорозмір);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        
        if (IsNew) 
            Елемент.Приміщення = ВласникДляНового;
        Назва.SetText(Елемент.Назва);
                        Приміщення.Pointer = Елемент.Приміщення;
                Папка.Pointer = Елемент.Папка;
                Лінія.SetText(Елемент.Лінія);
                        Позиція.SetText(Елемент.Позиція);
                        Стелаж.SetText(Елемент.Стелаж);
                        Ярус.SetText(Елемент.Ярус);
                        ТипСкладськоїКомірки.ActiveId = Елемент.ТипСкладськоїКомірки.ToString();
                Типорозмір.Pointer = Елемент.Типорозмір;
                
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Приміщення = Приміщення.Pointer;
                Елемент.Папка = Папка.Pointer;
                Елемент.Лінія = Лінія.GetText();
                        Елемент.Позиція = Позиція.GetText();
                        Елемент.Стелаж = Стелаж.GetText();
                        Елемент.Ярус = Ярус.GetText();
                        Елемент.ТипСкладськоїКомірки = ПсевдонімиПерелічення.ТипиСкладськихКомірок_FindByName(ТипСкладськоїКомірки.ActiveId);
                Елемент.Типорозмір = Типорозмір.Pointer;
                
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
    