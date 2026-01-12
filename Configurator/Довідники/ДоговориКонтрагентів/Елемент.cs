
/*
        ДоговориКонтрагентів_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class ДоговориКонтрагентів_Елемент : DirectoryFormElement
{
    public ДоговориКонтрагентів_Objest Елемент { get; init; } = new ДоговориКонтрагентів_Objest();
    
    public Контрагенти_Pointer ВласникДляНового = new Контрагенти_Pointer();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    Entry Код = new() { WidthRequest = 500 };
                    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = new() { Caption = "БанківськийРахунок", WidthPresentation = 500 };
            БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = new() { Caption = "БанківськийРахунокКонтрагента", WidthPresentation = 500 };
            Валюти_PointerControl ВалютаВзаєморозрахунків = new() { Caption = "ВалютаВзаєморозрахунків", WidthPresentation = 500 };
            DateTimeControl ДатаПочаткуДії = new(){ OnlyDate = true };
            DateTimeControl ДатаЗакінченняДії = new(){ OnlyDate = true };
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 500 };
            Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 500 };
            DateTimeControl Дата = new(){ OnlyDate = true };
            Entry Номер = new() { WidthRequest = 500 };
                    СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 500 };
            CheckButton Узгоджений = CheckButton.NewWithLabel("Узгоджений");
            ComboBoxText Статус = new ComboBoxText();
            ComboBoxText ГосподарськаОперація = new ComboBoxText();
            ComboBoxText ТипДоговору = new ComboBoxText();
            Entry ТипДоговоруПредставлення = new() { WidthRequest = 500 };
                    NumericControl ДопустимаСумаЗаборгованості = new();
            NumericControl Сума = new();
            Entry Коментар = new() { WidthRequest = 500 };
                    
    #endregion

    #region TabularParts
    
    #endregion

    public ДоговориКонтрагентів_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СтатусиДоговорівКонтрагентів_List())
                Статус.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            Статус.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List())
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ГосподарськаОперація.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипДоговорів_List())
                ТипДоговору.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ТипДоговору.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // БанківськийРахунок
            CreateField(vBox, null, БанківськийРахунок);
                
            // БанківськийРахунокКонтрагента
            CreateField(vBox, null, БанківськийРахунокКонтрагента);
                
            // ВалютаВзаєморозрахунків
            CreateField(vBox, null, ВалютаВзаєморозрахунків);
                
            // ДатаПочаткуДії
            CreateField(vBox, "ДатаПочаткуДії:", ДатаПочаткуДії);
                        
            // ДатаЗакінченняДії
            CreateField(vBox, "ДатаЗакінченняДії:", ДатаЗакінченняДії);
                        
            // Організація
            CreateField(vBox, null, Організація);
                
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
            // Дата
            CreateField(vBox, "Дата:", Дата);
                        
            // Номер
            CreateField(vBox, "Номер:", Номер);
                        
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Узгоджений
            CreateField(vBox, null, Узгоджений);
                
            // Статус
            CreateField(vBox, "Статус:", Статус);
                
            // ГосподарськаОперація
            CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);
                
            // ТипДоговору
            CreateField(vBox, "ТипДоговору:", ТипДоговору);
                
            // ТипДоговоруПредставлення
            CreateField(vBox, "ТипДоговоруПредставлення:", ТипДоговоруПредставлення);
                        
            // ДопустимаСумаЗаборгованості
            CreateField(vBox, "ДопустимаСумаЗаборгованості:", ДопустимаСумаЗаборгованості);
                        
            // Сума
            CreateField(vBox, "Сума:", Сума);
                        
            // Коментар
            CreateField(vBox, "Коментар:", Коментар);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        
        if (IsNew) 
            Елемент.Контрагент = ВласникДляНового;
        Назва.SetText(Елемент.Назва);
                        Код.SetText(Елемент.Код);
                        БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
                БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
                ВалютаВзаєморозрахунків.Pointer = Елемент.ВалютаВзаєморозрахунків;
                ДатаПочаткуДії.Value = Елемент.ДатаПочаткуДії;
                ДатаЗакінченняДії.Value = Елемент.ДатаЗакінченняДії;
                Організація.Pointer = Елемент.Організація;
                Контрагент.Pointer = Елемент.Контрагент;
                Дата.Value = Елемент.Дата;
                Номер.SetText(Елемент.Номер);
                        Підрозділ.Pointer = Елемент.Підрозділ;
                Узгоджений.Active = Елемент.Узгоджений;
                Статус.ActiveId = Елемент.Статус.ToString();
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                ТипДоговору.ActiveId = Елемент.ТипДоговору.ToString();
                ТипДоговоруПредставлення.SetText(Елемент.ТипДоговоруПредставлення);
                        ДопустимаСумаЗаборгованості.Value = Елемент.ДопустимаСумаЗаборгованості;
                Сума.Value = Елемент.Сума;
                Коментар.SetText(Елемент.Коментар);
                        
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Код = Код.GetText();
                        Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
                Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
                Елемент.ВалютаВзаєморозрахунків = ВалютаВзаєморозрахунків.Pointer;
                Елемент.ДатаПочаткуДії = ДатаПочаткуДії.Value;
                Елемент.ДатаЗакінченняДії = ДатаЗакінченняДії.Value;
                Елемент.Організація = Організація.Pointer;
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.Дата = Дата.Value;
                Елемент.Номер = Номер.GetText();
                        Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Узгоджений = Узгоджений.Active;
                Елемент.Статус = ПсевдонімиПерелічення.СтатусиДоговорівКонтрагентів_FindByName(Статус.ActiveId);
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.ТипДоговору = ПсевдонімиПерелічення.ТипДоговорів_FindByName(ТипДоговору.ActiveId);
                Елемент.ТипДоговоруПредставлення = ТипДоговоруПредставлення.GetText();
                        Елемент.ДопустимаСумаЗаборгованості = ДопустимаСумаЗаборгованості.Value;
                Елемент.Сума = Сума.Value;
                Елемент.Коментар = Коментар.GetText();
                        
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
    