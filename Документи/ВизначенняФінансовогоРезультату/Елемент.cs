
/*
        ВизначенняФінансовогоРезультату_Елемент.cs
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
using Функції = StorageAndTrade.ВизначенняФінансовогоРезультату_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_0paeAdT033eFMCX2uIMZg")]
partial class ВизначенняФінансовогоРезультату_Елемент : DocumentFormElement
{
    public ВизначенняФінансовогоРезультату_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    CheckButton ВідобразитиВБухгалтерськомуОбліку = CheckButton.NewWithLabel("Відобразити в бух обліку");

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ВизначенняФінансовогоРезультату_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxTop, null, ВідобразитиВБухгалтерськомуОбліку);
        CreateField(HBoxComment, "Коментар:", Коментар);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Основа:
        Основа.BoundConfType = "Документи.ВизначенняФінансовогоРезультату.Основа";

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;
    }

    public static ВизначенняФінансовогоРезультату_Елемент New()
    {
        ВизначенняФінансовогоРезультату_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    void CreateTopStart(Box vBox)
    {
        // Організація
        CreateField(vBox, null, Організація);
    }

    void CreateTopEnd(Box vBox)
    {

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

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Організація = await ЗначенняТипові.ОсновнаОрганізація();
        }

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Коментар.SetText(Елемент.Коментар);
        Основа.Pointer = Елемент.Основа;
        Організація.Pointer = Елемент.Організація;
        Автор.Pointer = Елемент.Автор;
        ВідобразитиВБухгалтерськомуОбліку.Active = Елемент.ВідобразитиВБухгалтерськомуОбліку;
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Основа = Основа.Pointer;
        Елемент.Організація = Організація.Pointer;
        Елемент.Автор = Автор.Pointer;
        Елемент.ВідобразитиВБухгалтерськомуОбліку = ВідобразитиВБухгалтерськомуОбліку.Active;
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ВизначенняФінансовогоРезультату_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
