
/*
        КасиККМ_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class КасиККМ_Елемент : DirectoryFormElement
{
    public КасиККМ_Objest Елемент { get; init; } = new КасиККМ_Objest();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 500 };
            ComboBoxText Тип = new ComboBoxText();
            Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 500 };
            
    #endregion

    #region TabularParts
    
    #endregion

    public КасиККМ_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипККМ_List())
                Тип.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            Тип.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Склад
            CreateField(vBox, null, Склад);
                
            // Тип
            CreateField(vBox, "Тип:", Тип);
                
            // Валюта
            CreateField(vBox, null, Валюта);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Назва.SetText(Елемент.Назва);
                        Склад.Pointer = Елемент.Склад;
                Тип.ActiveId = Елемент.Тип.ToString();
                Валюта.Pointer = Елемент.Валюта;
                
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Склад = Склад.Pointer;
                Елемент.Тип = ПсевдонімиПерелічення.ТипККМ_FindByName(Тип.ActiveId);
                Елемент.Валюта = Валюта.Pointer;
                
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
    