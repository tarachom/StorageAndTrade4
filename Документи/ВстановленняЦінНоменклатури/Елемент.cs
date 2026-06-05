
/*
        ВстановленняЦінНоменклатури_Елемент.cs
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
using Функції = StorageAndTrade.ВстановленняЦінНоменклатури_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_D5eeAY3cK3qRMi13BP5ueA")]
partial class ВстановленняЦінНоменклатури_Елемент : DocumentFormElement
{
    public ВстановленняЦінНоменклатури_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    public Валюти_PointerControl Валюта { get; } = Валюти_PointerControl.New();
    public ВидиЦін_PointerControl ВидЦіни { get; } = ВидиЦін_PointerControl.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ВстановленняЦінНоменклатури_ТабличнаЧастина_Товари Товари = ВстановленняЦінНоменклатури_ТабличнаЧастина_Товари.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ВстановленняЦінНоменклатури_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Товари"
        Товари.HeightRequest = 300;
        NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);

        NotebookTablePart.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //ВидЦіни:
        ВидЦіни.Caption = "Вид ціни";
        ВидЦіни.WidthPresentation = 300;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Основа:
        Основа.BoundConfType = "Документи.ВстановленняЦінНоменклатури.Основа";

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;
    }

    public static ВстановленняЦінНоменклатури_Елемент New()
    {
        ВстановленняЦінНоменклатури_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateTopStart(Box vBox)
    {
        // Організація
        CreateField(vBox, null, Організація);

        // Валюта
        CreateField(vBox, null, Валюта);
    }

    protected override void CreateTopEnd(Box vBox)
    {
        // ВидЦіни
        CreateField(vBox, null, ВидЦіни);
    }

    protected override void CreateBottomStart(Box vBox)
    {
        // Автор
        CreateField(vBox, null, Автор);
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
        }

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Організація.Pointer = Елемент.Організація;
        Валюта.Pointer = Елемент.Валюта;
        ВидЦіни.Pointer = Елемент.ВидЦіни;
        Коментар.SetText(Елемент.Коментар);
        Основа.Pointer = Елемент.Основа;
        Автор.Pointer = Елемент.Автор;

        // Таблична частина "Товари" 
        Товари.ЕлементВласник = Елемент;
        Товари.ЕлементВласникФорма = this;
        await Товари.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.Організація = Організація.Pointer;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.ВидЦіни = ВидЦіни.Pointer;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Основа = Основа.Pointer;
        Елемент.Автор = Автор.Pointer;
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ВстановленняЦінНоменклатури_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
