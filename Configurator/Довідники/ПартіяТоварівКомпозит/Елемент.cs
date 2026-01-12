
/*
        ПартіяТоварівКомпозит_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class ПартіяТоварівКомпозит_Елемент : DirectoryFormElement
{
    public ПартіяТоварівКомпозит_Objest Елемент { get; init; } = new ПартіяТоварівКомпозит_Objest();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    DateTimeControl Дата = new();
            ComboBoxText ТипДокументу = new ComboBoxText();
            //Guid ДокументКлюч = new();
            ПоступленняТоварівТаПослуг_PointerControl ПоступленняТоварівТаПослуг = new() { Caption = "ПоступленняТоварівТаПослуг", WidthPresentation = 500 };
            ВведенняЗалишків_PointerControl ВведенняЗалишків = new() { Caption = "ВведенняЗалишків", WidthPresentation = 500 };
            
    #endregion

    #region TabularParts
    
    #endregion

    public ПартіяТоварівКомпозит_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипДокументуПартіяТоварівКомпозит_List())
                ТипДокументу.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ТипДокументу.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Дата
            CreateField(vBox, "Дата:", Дата);
                        
            // ТипДокументу
            CreateField(vBox, "ТипДокументу:", ТипДокументу);
                
            // ДокументКлюч
            // ПоступленняТоварівТаПослуг
            CreateField(vBox, null, ПоступленняТоварівТаПослуг);
                
            // ВведенняЗалишків
            CreateField(vBox, null, ВведенняЗалишків);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Назва.SetText(Елемент.Назва);
                        Дата.Value = Елемент.Дата;
                ТипДокументу.ActiveId = Елемент.ТипДокументу.ToString();
                //ДокументКлюч = Елемент.ДокументКлюч;
                ПоступленняТоварівТаПослуг.Pointer = Елемент.ПоступленняТоварівТаПослуг;
                ВведенняЗалишків.Pointer = Елемент.ВведенняЗалишків;
                
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Дата = Дата.Value;
                Елемент.ТипДокументу = ПсевдонімиПерелічення.ТипДокументуПартіяТоварівКомпозит_FindByName(ТипДокументу.ActiveId);
                //Елемент.ДокументКлюч = ДокументКлюч;
                Елемент.ПоступленняТоварівТаПослуг = ПоступленняТоварівТаПослуг.Pointer;
                Елемент.ВведенняЗалишків = ВведенняЗалишків.Pointer;
                
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
    