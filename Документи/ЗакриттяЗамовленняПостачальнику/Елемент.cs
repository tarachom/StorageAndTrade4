
/*
        ЗакриттяЗамовленняПостачальнику_Елемент.cs
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
using Функції = StorageAndTrade.ЗакриттяЗамовленняПостачальнику_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_oI2eAQrR13CORDUWPtOajQ")]
partial class ЗакриттяЗамовленняПостачальнику_Елемент : DocumentFormElement
{
    public ЗакриттяЗамовленняПостачальнику_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    ComboBoxText ПричинаЗакриттяЗамовлення = ComboBoxText.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    ЗамовленняПостачальнику_PointerControl ЗамовленняПостачальнику = ЗамовленняПостачальнику_PointerControl.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Entry Коментар = Entry.New();
    Користувачі_PointerControl Менеджер = Користувачі_PointerControl.New();
    CompositePointerControl Основа = CompositePointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ЗакриттяЗамовленняПостачальнику_ТабличнаЧастина_Товари Товари = ЗакриттяЗамовленняПостачальнику_ТабличнаЧастина_Товари.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ЗакриттяЗамовленняПостачальнику_Const.FULLNAME, НомерДок, ДатаДок);
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

        //ПричинаЗакриттяЗамовлення:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ПричиниЗакриттяЗамовленняПостачальнику_List())
                ПричинаЗакриттяЗамовлення.Append(field.Value.ToString(), field.Name);

            ПричинаЗакриттяЗамовлення.Active = 0;
            ПричинаЗакриттяЗамовлення.AddController(FunctionForComboBox.DisableScrolling());
        }

        //Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        //ЗамовленняПостачальнику:
        ЗамовленняПостачальнику.Caption = "Замовлення";
        ЗамовленняПостачальнику.WidthPresentation = 300;

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
        Основа.BoundConfType = "Документи.ЗакриттяЗамовленняПостачальнику.Основа";
    }

    public static ЗакриттяЗамовленняПостачальнику_Елемент New()
    {
        ЗакриттяЗамовленняПостачальнику_Елемент element = NewWithProperties([]);
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

        // ЗамовленняПостачальнику
        CreateField(vBox, null, ЗамовленняПостачальнику);
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
        CreateField(vBox, "Причина закриття:", ПричинаЗакриттяЗамовлення);
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
        ПричинаЗакриттяЗамовлення.ActiveId = Елемент.ПричинаЗакриттяЗамовлення.ToString();
        Склад.Pointer = Елемент.Склад;
        ЗамовленняПостачальнику.Pointer = Елемент.ЗамовленняПостачальнику;
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
        Елемент.ПричинаЗакриттяЗамовлення = ПсевдонімиПерелічення.ПричиниЗакриттяЗамовленняПостачальнику_FindByName(ПричинаЗакриттяЗамовлення.ActiveId);
        Елемент.Склад = Склад.Pointer;
        Елемент.ЗамовленняПостачальнику = ЗамовленняПостачальнику.Pointer;
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ЗакриттяЗамовленняПостачальнику_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
