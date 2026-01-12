
/*
        ВидиНоменклатури_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class ВидиНоменклатури_Елемент : DirectoryFormElement
{
    public ВидиНоменклатури_Objest Елемент { get; init; } = new ВидиНоменклатури_Objest();
    
    #region Fields
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 500 };
                    TextView Опис = new TextView() { WrapMode = WrapMode.Word };
                    ПакуванняОдиниціВиміру_PointerControl ОдиницяВиміру = new() { Caption = "Пакування:", WidthPresentation = 300 };
            ComboBoxText ТипНоменклатури = new ComboBoxText();
            
    #endregion

    #region TabularParts
    
    #endregion

    public ВидиНоменклатури_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипиНоменклатури_List())
                ТипНоменклатури.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ТипНоменклатури.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Опис
            CreateFieldView(vBox, "Опис:", Опис, 500, 200);
                        
            // ОдиницяВиміру
            CreateField(vBox, null, ОдиницяВиміру);
                
            // ТипНоменклатури
            CreateField(vBox, "Тип:", ТипНоменклатури);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        Опис.Buffer?.Text = Елемент.Опис;
                        ОдиницяВиміру.Pointer = Елемент.ОдиницяВиміру;
                ТипНоменклатури.ActiveId = Елемент.ТипНоменклатури.ToString();
                
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.Опис = Опис.Buffer?.Text ?? "";
                        Елемент.ОдиницяВиміру = ОдиницяВиміру.Pointer;
                Елемент.ТипНоменклатури = ПсевдонімиПерелічення.ТипиНоменклатури_FindByName(ТипНоменклатури.ActiveId);
                
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
    