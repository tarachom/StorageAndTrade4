
/*
        ЗакриттяРахункуФактури_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Константи;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.ЗакриттяРахункуФактури_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_c42eARtc366zsdptyICJg")]
partial class ЗакриттяРахункуФактури_Елемент : DocumentFormElement
{
    public ЗакриттяРахункуФактури_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    ComboBoxText ПричинаЗакриттяРахунку = ComboBoxText.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    РахунокФактура_PointerControl РахунокФактура = РахунокФактура_PointerControl.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Entry Коментар = Entry.New();
    Користувачі_PointerControl Менеджер = Користувачі_PointerControl.New();
    CompositePointerControl Основа = CompositePointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ЗакриттяРахункуФактури_ТабличнаЧастина_Товари Товари = ЗакриттяРахункуФактури_ТабличнаЧастина_Товари.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ЗакриттяРахункуФактури_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Товари"
        Товари.HeightRequest = 300;
        NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
        NotebookTablePart.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //ПричинаЗакриттяРахунку:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ПричиниЗакриттяРахункуФактури_List())
                ПричинаЗакриттяРахунку.Append(field.Value.ToString(), field.Name);

            ПричинаЗакриттяРахунку.Active = 0;
            ПричинаЗакриттяРахунку.AddController(FunctionForComboBox.DisableScrolling());
        }

        //Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        //РахунокФактура:
        РахунокФактура.Caption = "Рахунок фактура";
        РахунокФактура.WidthPresentation = 300;

        //Каса:
        Каса.Caption = "Каса";
        Каса.WidthPresentation = 300;

        //Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Менеджер:
        Менеджер.Caption = "Менеджер";
        Менеджер.WidthPresentation = 300;

        //Основа:
        Основа.BoundConfType = "Документи.ЗакриттяРахункуФактури.Основа";
    }

    public static ЗакриттяРахункуФактури_Елемент New()
    {
        ЗакриттяРахункуФактури_Елемент element = NewWithProperties([]);
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

        // РахунокФактура
        CreateField(vBox, null, РахунокФактура);
    }

    protected override void CreateTopEnd(Box vBox)
    {
        //Каса
        CreateField(vBox, null, Каса);

        //Валюта
        CreateField(vBox, null, Валюта);

        //Склад
        CreateField(vBox, null, Склад);

        // ПричинаЗакриттяЗамовлення
        CreateField(vBox, "Причина закриття:", ПричинаЗакриттяРахунку);
    }

    protected override void CreateBottomStart(Box vBox)
    {
        // Автор
        CreateField(vBox, null, Автор);

        // Менеджер
        CreateField(vBox, null, Менеджер);
    }

    protected override void CreateBottomEnd(Box vBox)
    {
        // Основа
        CreateField(vBox, null, Основа);
    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Організація = await ЗначенняТипові.ОсновнаОрганізація();
            Елемент.Валюта = await ЗначенняТипові.ОсновнаВалюта();
            Елемент.Каса = await ЗначенняТипові.ОсновнаКаса();
            Елемент.Склад = await ЗначенняТипові.ОсновнийСклад();
            Елемент.Контрагент = await ЗначенняТипові.ОсновнийПокупець();
        }

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Контрагент.Pointer = Елемент.Контрагент;
        Організація.Pointer = Елемент.Організація;
        Валюта.Pointer = Елемент.Валюта;
        ПричинаЗакриттяРахунку.ActiveId = Елемент.ПричинаЗакриттяРахунку.ToString();
        Склад.Pointer = Елемент.Склад;
        РахунокФактура.Pointer = Елемент.РахунокФактура;
        Каса.Pointer = Елемент.Каса;
        Договір.Pointer = Елемент.Договір;
        Автор.Pointer = Елемент.Автор;
        Коментар.SetText(Елемент.Коментар);
        Менеджер.Pointer = Елемент.Менеджер;
        Основа.Pointer = Елемент.Основа;

        // Таблична частина "Товари" 
        Товари.ЕлементВласник = Елемент;
        await Товари.LoadRecords();

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
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.Організація = Організація.Pointer;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.ПричинаЗакриттяРахунку = ПсевдонімиПерелічення.ПричиниЗакриттяРахункуФактури_FindByName(ПричинаЗакриттяРахунку.ActiveId);
        Елемент.Склад = Склад.Pointer;
        Елемент.РахунокФактура = РахунокФактура.Pointer;
        Елемент.Каса = Каса.Pointer;
        Елемент.Договір = Договір.Pointer;
        Елемент.Автор = Автор.Pointer;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Менеджер = Менеджер.Pointer;
        Елемент.Основа = Основа.Pointer;
        Елемент.СумаДокументу = Товари.СумаДокументу();
    }

    #endregion

    protected override async Task<bool> Save()
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ЗакриттяРахункуФактури_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
