
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
    public СтаттяРухуКоштів_Objest Елемент { get; init; } = new();
    
    #region Fields
    Entry Код = Entry.New();
                    Entry Назва = Entry.New();
                    Entry КореспондуючийРахунок = Entry.New();
                    ComboBoxText ВидРухуКоштів = ComboBoxText.New();
            Entry Опис = Entry.New();
                    
    #endregion

    #region TabularParts
    
    #endregion

    public СтаттяРухуКоштів_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;

        Код.WidthRequest = 100;
                        Назва.WidthRequest = 300;
                        КореспондуючийРахунок.WidthRequest = 300;
                        
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.ВидиРухуКоштів_List())
                    ВидРухуКоштів.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                ВидРухуКоштів.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                Опис.WidthRequest = 300;
                        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // КореспондуючийРахунок
            CreateField(vBox, "Кореспондуючий рахунок:", КореспондуючийРахунок);
                        
            // ВидРухуКоштів
            CreateField(vBox, "Вид руху коштів:", ВидРухуКоштів);
                
            // Опис
            CreateField(vBox, "Опис:", Опис);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        КореспондуючийРахунок.SetText(Елемент.КореспондуючийРахунок);
                        ВидРухуКоштів.ActiveId = Елемент.ВидРухуКоштів.ToString();
                Опис.SetText(Елемент.Опис);
                        
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
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
        catch (Exception ex)
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    