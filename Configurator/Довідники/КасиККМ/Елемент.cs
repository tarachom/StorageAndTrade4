
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
    public КасиККМ_Objest Елемент { get; init; } = new();
    
    #region Fields
    Entry Назва = Entry.New();
                    Склади_PointerControl Склад = Склади_PointerControl.New();
            ComboBoxText Тип = ComboBoxText.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            
    #endregion

    #region TabularParts
    
    #endregion

    public КасиККМ_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;

        Назва.WidthRequest = 300;
                        Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.ТипККМ_List())
                    Тип.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                Тип.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                
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
    