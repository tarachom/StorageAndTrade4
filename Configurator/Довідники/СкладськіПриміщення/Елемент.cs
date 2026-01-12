
/*
        СкладськіПриміщення_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class СкладськіПриміщення_Елемент : DirectoryFormElement
{
    public СкладськіПриміщення_Objest Елемент { get; init; } = new СкладськіПриміщення_Objest();
    
    public Склади_Pointer ВласникДляНового = new Склади_Pointer();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    ComboBoxText НалаштуванняАдресногоЗберігання = new ComboBoxText();
            Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 500 };
            
    #endregion

    #region TabularParts
    
    #endregion

    public СкладськіПриміщення_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_List())
                НалаштуванняАдресногоЗберігання.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            НалаштуванняАдресногоЗберігання.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // НалаштуванняАдресногоЗберігання
            CreateField(vBox, "Адресне зберігання:", НалаштуванняАдресногоЗберігання);
                
            // Склад
            CreateField(vBox, null, Склад);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        
        if (IsNew) 
            Елемент.Склад = ВласникДляНового;
        Назва.SetText(Елемент.Назва);
                        НалаштуванняАдресногоЗберігання.ActiveId = Елемент.НалаштуванняАдресногоЗберігання.ToString();
                Склад.Pointer = Елемент.Склад;
                
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.НалаштуванняАдресногоЗберігання = ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_FindByName(НалаштуванняАдресногоЗберігання.ActiveId);
                Елемент.Склад = Склад.Pointer;
                
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
    