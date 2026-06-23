
/*
        ДоговориКонтрагентів_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_KJSgWXQS2EyhyfX7APw")]
partial class ДоговориКонтрагентів_Елемент : DirectoryFormElement
{
    public ДоговориКонтрагентів_Object Елемент { get; init; } = new();

    public Контрагенти_Pointer ВласникДляНового = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
    БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = БанківськіРахункиКонтрагентів_PointerControl.New();
    Валюти_PointerControl ВалютаВзаєморозрахунків = Валюти_PointerControl.New();
    DateTimeControl ДатаПочаткуДії = DateTimeControl.New();
    DateTimeControl ДатаЗакінченняДії = DateTimeControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    DateTimeControl Дата = DateTimeControl.New();
    Entry Номер = Entry.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    CheckButton Узгоджений = CheckButton.NewWithLabel("Узгоджений");
    ComboBoxText Статус = ComboBoxText.New();
    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
    ComboBoxText ТипДоговору = ComboBoxText.New();
    NumericControl ДопустимаСумаЗаборгованості = NumericControl.New();
    NumericControl Сума = NumericControl.New();
    Entry Коментар = Entry.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Код:
        Код.WidthRequest = 100;

        // Назва:
        Назва.WidthRequest = 500;

        // Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        // БанківськийРахунок:
        БанківськийРахунок.Caption = "Банківський рахунок";
        БанківськийРахунок.WidthPresentation = 300;

        // БанківськийРахунокКонтрагента:
        БанківськийРахунокКонтрагента.Caption = "Банківський рахунок контрагента";
        БанківськийРахунокКонтрагента.WidthPresentation = 300;

        // ВалютаВзаєморозрахунків:
        ВалютаВзаєморозрахунків.Caption = "Валюта";
        ВалютаВзаєморозрахунків.WidthPresentation = 300;

        // ДатаПочаткуДії:
        ДатаПочаткуДії.OnlyDate = true;

        // ДатаЗакінченняДії:
        ДатаЗакінченняДії.OnlyDate = true;

        // Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        // Дата:
        Дата.OnlyDate = true;

        // Номер:
        Номер.WidthRequest = 300;

        // Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        // Статус:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СтатусиДоговорівКонтрагентів_List())
                Статус.Append(field.Value.ToString(), field.Name);

            Статус.ActiveId = СтатусиДоговорівКонтрагентів.Діє.ToString();
            Статус.AddController(FunctionForComboBox.DisableScrolling());
        }

        // ГосподарськаОперація:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List())
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            ГосподарськаОперація.ActiveId = ГосподарськіОперації.РеалізаціяКлієнту.ToString();
            ГосподарськаОперація.AddController(FunctionForComboBox.DisableScrolling());
        }

        // ТипДоговору:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипДоговорів_List())
                ТипДоговору.Append(field.Value.ToString(), field.Name);

            ТипДоговору.ActiveId = ТипДоговорів.ЗПокупцями.ToString();
            ТипДоговору.AddController(FunctionForComboBox.DisableScrolling());
        }

        // Коментар:
        Коментар.WidthRequest = 500;
    }

    public static ДоговориКонтрагентів_Елемент New()
    {
        ДоговориКонтрагентів_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        //Код
        CreateField(vBox, "Код:", Код);

        //Назва
        CreateField(vBox, "Назва:", Назва);

        //Дата
        CreateField(vBox, "Дата:", Дата);

        //Номер
        CreateField(vBox, "Номер:", Номер);

        //БанківськийРахунок
        CreateField(vBox, null, БанківськийРахунок);

        //БанківськийРахунокКонтрагента
        CreateField(vBox, null, БанківськийРахунокКонтрагента);

        //ВалютаВзаєморозрахунків
        CreateField(vBox, null, ВалютаВзаєморозрахунків);

        //ДатаПочаткуДії
        CreateField(vBox, "Дата початку дії:", ДатаПочаткуДії);

        //ДатаЗакінченняДії
        CreateField(vBox, "Дата закінчення дії:", ДатаЗакінченняДії);

        //Організація
        CreateField(vBox, null, Організація);

        //Контрагент
        CreateField(vBox, null, Контрагент);

        //Підрозділ
        CreateField(vBox, null, Підрозділ);

        //Узгоджений
        CreateField(vBox, null, Узгоджений);

        //Статус
        CreateField(vBox, "Статус:", Статус);

        //ГосподарськаОперація
        CreateField(vBox, "Господарська операція:", ГосподарськаОперація);

        //ТипДоговору
        CreateField(vBox, "Тип договору:", ТипДоговору);

        //ДопустимаСумаЗаборгованості
        CreateField(vBox, "Допустима сума заборгованості:", ДопустимаСумаЗаборгованості);

        //Сума
        CreateField(vBox, "Сума:", Сума);

        //Коментар
        CreateField(vBox, "Коментар:", Коментар);
    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
            Елемент.Контрагент = ВласникДляНового;

        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
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
        ДопустимаСумаЗаборгованості.Value = Елемент.ДопустимаСумаЗаборгованості;
        Сума.Value = Елемент.Сума;
        Коментар.SetText(Елемент.Коментар);
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
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
        Елемент.ДопустимаСумаЗаборгованості = ДопустимаСумаЗаборгованості.Value;
        Елемент.Сума = Сума.Value;
        Елемент.Коментар = Коментар.GetText();
    }

    #endregion

    protected override async Task<bool> Save()
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
            ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
