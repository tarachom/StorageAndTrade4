
/*
        СтаттяРухуКоштів_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class СтаттяРухуКоштів_Елемент : DirectoryFormElement
{
    public СтаттяРухуКоштів_Objest Елемент { get; init; } = new СтаттяРухуКоштів_Objest();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    Entry Код = new() { WidthRequest = 500 };
                    Entry КореспондуючийРахунок = new() { WidthRequest = 500 };
                    ComboBoxText ВидРухуКоштів = new ComboBoxText();
            Entry Опис = new() { WidthRequest = 500 };
                    
    #endregion

    #region TabularParts
    
    #endregion

    public СтаттяРухуКоштів_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ВидиРухуКоштів_List())
                ВидРухуКоштів.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ВидРухуКоштів.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // КореспондуючийРахунок
            CreateField(vBox, "КореспондуючийРахунок:", КореспондуючийРахунок);
                        
            // ВидРухуКоштів
            CreateField(vBox, "ВидРухуКоштів:", ВидРухуКоштів);
                
            // Опис
            CreateField(vBox, "Опис:", Опис);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Назва.SetText(Елемент.Назва);
                        Код.SetText(Елемент.Код);
                        КореспондуючийРахунок.SetText(Елемент.КореспондуючийРахунок);
                        ВидРухуКоштів.ActiveId = Елемент.ВидРухуКоштів.ToString();
                Опис.SetText(Елемент.Опис);
                        
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Код = Код.GetText();
                        Елемент.КореспондуючийРахунок = КореспондуючийРахунок.GetText();
                        Елемент.ВидРухуКоштів = ПсевдонімиПерелічення.ВидиРухуКоштів_FindByName(ВидРухуКоштів.ActiveId);
                Елемент.Опис = Опис.GetText();
                        
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
        catch
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    