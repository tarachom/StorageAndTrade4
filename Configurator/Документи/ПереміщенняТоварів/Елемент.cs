
/*
        ПереміщенняТоварів_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode;
using GeneratedCode.Константи;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.ПереміщенняТоварів_Функції;

namespace StorageAndTrade;

class ПереміщенняТоварів_Елемент : DocumentFormElement
{
    public ПереміщенняТоварів_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new();
    DateTimeControl ДатаДок = new();
    Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = new() { Caption = "БанківськийРахунокОрганізації", WidthPresentation = 300 };
    ВидиЦін_PointerControl ВидЦіни = new() { Caption = "ВидЦіни", WidthPresentation = 300 };
    Організації_PointerControl ОрганізаціяОтримувач = new() { Caption = "ОрганізаціяОтримувач", WidthPresentation = 300 };
    Користувачі_PointerControl Відповідальний = new() { Caption = "Відповідальний", WidthPresentation = 300 };
    СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 300 };
    Склади_PointerControl СкладВідправник = new() { Caption = "СкладВідправник", WidthPresentation = 300 };
    Склади_PointerControl СкладОтримувач = new() { Caption = "СкладОтримувач", WidthPresentation = 300 };
    ComboBoxText Статус = new ComboBoxText();
    ComboBoxText ГосподарськаОперація = new ComboBoxText();
    ComboBoxText СпосібДоставки = new ComboBoxText();
    Entry АдресДоставки = new() { WidthRequest = 300 };
    TimeControl ЧасДоставкиЗ = new();
    TimeControl ЧасДоставкиДо = new();
    Entry Коментар = new() { WidthRequest = 1200 };
    CompositePointerControl Основа = new() { BoundConfType = "Документи.ПереміщенняТоварів.Основа" };

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ПереміщенняТоварів_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };

    #endregion

    public ПереміщенняТоварів_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ПереміщенняТоварів_Const.FULLNAME, НомерДок, ДатаДок);

        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Товари" 
        NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);

        NotebookTablePart.SetCurrentPage(0);

        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СтатусиПереміщенняТоварів_List())
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
            foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                СпосібДоставки.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            СпосібДоставки.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

    }

    protected override void CreateTopStart(Box vBox)
    {
        // Організація
        CreateField(vBox, null, Організація);
    }

    protected override void CreateTopEnd(Box vBox)
    {
        // СкладВідправник
        CreateField(vBox, null, СкладВідправник);

        // СкладОтримувач
        CreateField(vBox, null, СкладОтримувач);
    }

    protected override void CreateBottomStart(Box vBox)
    {
        // БанківськийРахунокОрганізації
        CreateField(vBox, null, БанківськийРахунокОрганізації);

        // ВидЦіни
        CreateField(vBox, null, ВидЦіни);

        // ОрганізаціяОтримувач
        CreateField(vBox, null, ОрганізаціяОтримувач);

        // Відповідальний
        CreateField(vBox, null, Відповідальний);

        // Підрозділ
        CreateField(vBox, null, Підрозділ);

        // Статус
        CreateField(vBox, "Статус:", Статус);

        // ГосподарськаОперація
        CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);

        // СпосібДоставки
        CreateField(vBox, "СпосібДоставки:", СпосібДоставки);

        // АдресДоставки
        CreateField(vBox, "АдресДоставки:", АдресДоставки);

        // ЧасДоставкиЗ
        CreateField(vBox, "ЧасДоставкиЗ:", ЧасДоставкиЗ);

        // ЧасДоставкиДо
        CreateField(vBox, "ЧасДоставкиДо:", ЧасДоставкиДо);
    }

    protected override void CreateBottomEnd(Box vBox)
    {
// Основа
        CreateField(vBox, null, Основа);
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Організація.Pointer = Елемент.Організація;
        БанківськийРахунокОрганізації.Pointer = Елемент.БанківськийРахунокОрганізації;
        ВидЦіни.Pointer = Елемент.ВидЦіни;
        ОрганізаціяОтримувач.Pointer = Елемент.ОрганізаціяОтримувач;
        Відповідальний.Pointer = Елемент.Відповідальний;
        Підрозділ.Pointer = Елемент.Підрозділ;
        СкладВідправник.Pointer = Елемент.СкладВідправник;
        СкладОтримувач.Pointer = Елемент.СкладОтримувач;
        Статус.ActiveId = Елемент.Статус.ToString();
        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
        СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
        АдресДоставки.SetText(Елемент.АдресДоставки);
        ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
        ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
        Коментар.SetText(Елемент.Коментар);
        Основа.Pointer = Елемент.Основа;

        // Таблична частина "Товари" 
        Товари.ЕлементВласник = Елемент;
        await Товари.LoadRecords();

    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.Організація = Організація.Pointer;
        Елемент.БанківськийРахунокОрганізації = БанківськийРахунокОрганізації.Pointer;
        Елемент.ВидЦіни = ВидЦіни.Pointer;
        Елемент.ОрганізаціяОтримувач = ОрганізаціяОтримувач.Pointer;
        Елемент.Відповідальний = Відповідальний.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.СкладВідправник = СкладВідправник.Pointer;
        Елемент.СкладОтримувач = СкладОтримувач.Pointer;
        Елемент.Статус = ПсевдонімиПерелічення.СтатусиПереміщенняТоварів_FindByName(Статус.ActiveId);
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
        Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
        Елемент.АдресДоставки = АдресДоставки.GetText();
        Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
        Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Основа = Основа.Pointer;

    }


    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {БанківськийРахунокОрганізації.Pointer.Назва} {ВидЦіни.Pointer.Назва} {ОрганізаціяОтримувач.Pointer.Назва} {Відповідальний.Pointer.Назва} {Підрозділ.Pointer.Назва} {СкладВідправник.Pointer.Назва} {СкладОтримувач.Pointer.Назва}"
         + Товари.КлючовіСловаДляПошуку();
    }*/


    #endregion

    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await Товари.SaveRecords(); // Таблична частина "Товари"

                isSaved = true;
            }
        }
        catch (Exception ex)
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }

    protected override async ValueTask<bool> SpendTheDocument(bool spendDoc)
    {
        if (spendDoc)
        {
            bool isSpend = await Елемент.SpendTheDocument(Елемент.ДатаДок);
            //if (!isSpend) ФункціїДляПовідомлень.ПоказатиПовідомлення(Елемент.UnigueID);
            return isSpend;
        }
        else
        {
            await Елемент.ClearSpendTheDocument();
            return true;
        }
    }

    protected override void ReportSpendTheDocument(UnigueID unigueID)
    {
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ПереміщенняТоварів_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
