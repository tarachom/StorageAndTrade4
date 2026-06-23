
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
    public ВстановленняЦінНоменклатури_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    ВидиЦін_PointerControl ВидЦіни = ВидиЦін_PointerControl.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();

    #endregion

    #region Значення полів на зовні (тільки читання)
    public Валюти_Pointer Валюта_Значення { get => Валюта.Pointer; }
    public ВидиЦін_Pointer ВидЦіни_Значення { get => ВидЦіни.Pointer; }

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ВстановленняЦінНоменклатури_ТабличнаЧастина_Товари Товари = ВстановленняЦінНоменклатури_ТабличнаЧастина_Товари.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ВстановленняЦінНоменклатури_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "Товари"
        Товари.HeightRequest = 300;
        Interface.Notebook.InsertPage(Товари, Label.New("Товари"), 0);

        Interface.Notebook.SetCurrentPage(0);

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

    #region Interface

    FunctionForInterfaces.DocumentElement Interface;

    protected override void BuildInterface()
    {
        Interface = FunctionForInterfaces.ForDocument();

        Append(Interface.MainBox);

        CreateTopStart(Interface.TopStartBox);
        CreateTopEnd(Interface.TopEndBox);
        CreateBottomStart(Interface.BottomStartBox);
        CreateBottomEnd(Interface.BottomEndBox);
    }

    void CreateTopStart(Box vBox)
    {
        // Організація
        CreateField(vBox, null, Організація);

        // Валюта
        CreateField(vBox, null, Валюта);
    }

    void CreateTopEnd(Box vBox)
    {
        // ВидЦіни
        CreateField(vBox, null, ВидЦіни);
    }

    void CreateBottomStart(Box vBox)
    {
        // Автор
        CreateField(vBox, null, Автор);
    }

    void CreateBottomEnd(Box vBox)
    {
        // Основа
        CreateField(vBox, null, Основа);
    }

    #endregion

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
