
/*
        АктВиконанихРобіт_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.АктВиконанихРобіт_Функції;
using GeneratedCode.Константи;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_LSmlvSiulEyUyxLlU6VTuA")]
partial class АктВиконанихРобіт_Елемент : DocumentFormElement
{
    public АктВиконанихРобіт_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    ComboBoxText ФормаОплати = ComboBoxText.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Користувачі_PointerControl Менеджер = Користувачі_PointerControl.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Основа = CompositePointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Послуги" 
    АктВиконанихРобіт_ТабличнаЧастина_Послуги Послуги = АктВиконанихРобіт_ТабличнаЧастина_Послуги.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(АктВиконанихРобіт_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Послуги"
        Послуги.HeightRequest = 300;
        NotebookTablePart.InsertPage(Послуги, Label.New("Послуги"), 0);

        NotebookTablePart.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //Каса:
        Каса.Caption = "Каса";
        Каса.WidthPresentation = 300;

        //Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //ФормаОплати:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ФормаОплати_List())
                ФормаОплати.Append(field.Value.ToString(), field.Name);

            ФормаОплати.Active = 0;

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ФормаОплати.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

        //Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;

        //ГосподарськаОперація:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List()
                .Where(x => x.Value == ГосподарськіОперації.РеалізаціяКлієнту))
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            ГосподарськаОперація.Active = 0;

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ГосподарськаОперація.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //Менеджер:
        Менеджер.Caption = "Менеджер";
        Менеджер.WidthPresentation = 300;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Основа:
        Основа.BoundConfType = "Документи.АктВиконанихРобіт.Основа";
    }

    public static АктВиконанихРобіт_Елемент New()
    {
        АктВиконанихРобіт_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateTopStart(Box vBox)
    {
        //Організація
        CreateField(vBox, null, Організація);

        //Контрагент
        CreateField(vBox, null, Контрагент);
        Контрагент.AfterSelectFunc = async () => await Контрагент.ПривязкаДоДоговору(Договір);

        //Договір
        CreateField(vBox, null, Договір);
        Договір.BeforeClickOpenFunc = () => Договір.Власник = Контрагент.Pointer;
    }

    protected override void CreateTopEnd(Box vBox)
    {
        //Каса
        CreateField(vBox, null, Каса);

        //Валюта
        CreateField(vBox, null, Валюта);
    }

    protected override void CreateBottomStart(Box vBox)
    {
        //ГосподарськаОперація
        CreateField(vBox, "Господарська операція:", ГосподарськаОперація);

        //Підрозділ
        CreateField(vBox, null, Підрозділ);

        //Автор
        CreateField(vBox, null, Автор);
    }

    protected override void CreateBottomEnd(Box vBox)
    {
        //ФормаОплати
        CreateField(vBox, "Форма оплати:", ФормаОплати);

        //Основа
        CreateField(vBox, null, Основа);

        //Менеджер
        CreateField(vBox, null, Менеджер);
    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Організація = await ЗначенняТипові.ОсновнаОрганізація();
            Елемент.Валюта = await ЗначенняТипові.ОсновнаВалюта();
            Елемент.Каса = await ЗначенняТипові.ОсновнаКаса();
            Елемент.Контрагент = await ЗначенняТипові.ОсновнийПостачальник();
            Елемент.Підрозділ = await ЗначенняТипові.ОсновнийПідрозділ();
        }

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Валюта.Pointer = Елемент.Валюта;
        Каса.Pointer = Елемент.Каса;
        Контрагент.Pointer = Елемент.Контрагент;
        Організація.Pointer = Елемент.Організація;
        Підрозділ.Pointer = Елемент.Підрозділ;
        ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
        Договір.Pointer = Елемент.Договір;
        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
        Автор.Pointer = Елемент.Автор;
        Менеджер.Pointer = Елемент.Менеджер;
        Коментар.SetText(Елемент.Коментар);
        Основа.Pointer = Елемент.Основа;

        // Таблична частина "Послуги" 
        Послуги.ЕлементВласник = Елемент;
        await Послуги.LoadRecords();

        if (IsNew)
        {
            //Основний договір
            Контрагент.AfterSelectFunc?.Invoke();
        }
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.Каса = Каса.Pointer;
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.Організація = Організація.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
        Елемент.Договір = Договір.Pointer;
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
        Елемент.Автор = Автор.Pointer;
        Елемент.Менеджер = Менеджер.Pointer;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Основа = Основа.Pointer;

        Елемент.СумаДокументу = Послуги.СумаДокументу();
    }

    #endregion

    protected override async Task<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await Послуги.SaveRecords(); // Таблична частина "Послуги"

                isSaved = true;
            }
        }
        catch (Exception ex)
        {
            ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }

    protected override async Task<bool> SpendTheDocument(bool spendDoc)
    {
        if (spendDoc)
        {
            bool isSpend = await Елемент.SpendTheDocument(Елемент.ДатаДок);
            if (!isSpend) ФункціїДляПовідомлень.ПоказатиПовідомлення(Елемент.UniqueID);
            return isSpend;
        }
        else
        {
            await Елемент.ClearSpendTheDocument();
            return true;
        }
    }

    protected override void ReportSpendTheDocument(UniqueID uniqueID)
    {
        CommonForms_DocumentMovementThroughRegisters.Create(new АктВиконанихРобіт_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
