
/*
        КорегуванняБоргу_Елемент.cs
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
using Функції = StorageAndTrade.КорегуванняБоргу_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_z5GeARuLzXWSUwIWeHuvQ")]
partial class КорегуванняБоргу_Елемент : DocumentFormElement
{
    public КорегуванняБоргу_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    CheckButton ВідобразитиВБухгалтерськомуОбліку = CheckButton.NewWithLabel("Відобразити в бух обліку");

    #endregion

    #region TabularParts

    // Таблична частина "РозрахункиЗКонтрагентами" 
    КорегуванняБоргу_ТабличнаЧастина_РозрахункиЗКонтрагентами РозрахункиЗКонтрагентами = КорегуванняБоргу_ТабличнаЧастина_РозрахункиЗКонтрагентами.New();

    // Таблична частина "Проводки" 
    КорегуванняБоргу_ТабличнаЧастина_Проводки Проводки = КорегуванняБоргу_ТабличнаЧастина_Проводки.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(КорегуванняБоргу_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxTop, null, ВідобразитиВБухгалтерськомуОбліку);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "РозрахункиЗКонтрагентами"
        РозрахункиЗКонтрагентами.HeightRequest = 300;
        Interface.Notebook.InsertPage(РозрахункиЗКонтрагентами, Label.New("Розрахунки з контрагентами"), 0);

        // Таблична частина "Проводки"
        Проводки.HeightRequest = 300;
        Interface.Notebook.InsertPage(Проводки, Label.New("Проводки"), 1);

        Interface.Notebook.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Основа:
        Основа.BoundConfType = "Документи.КорегуванняБоргу.Основа";

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;
    }

    public static КорегуванняБоргу_Елемент New()
    {
        КорегуванняБоргу_Елемент element = NewWithProperties([]);
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
        //Організація
        CreateField(vBox, null, Організація);
    }

    void CreateTopEnd(Box vBox)
    {

    }

    void CreateBottomStart(Box vBox)
    {
        //Підрозділ
        CreateField(vBox, null, Підрозділ);

        //Автор
        CreateField(vBox, null, Автор);
    }

    void CreateBottomEnd(Box vBox)
    {
        //Основа
        CreateField(vBox, null, Основа);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Організація = await ЗначенняТипові.ОсновнаОрганізація();
            Елемент.Підрозділ = await ЗначенняТипові.ОсновнийПідрозділ();
        }

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Організація.Pointer = Елемент.Організація;
        Підрозділ.Pointer = Елемент.Підрозділ;
        Коментар.SetText(Елемент.Коментар);
        Основа.Pointer = Елемент.Основа;
        Автор.Pointer = Елемент.Автор;
        ВідобразитиВБухгалтерськомуОбліку.Active = Елемент.ВідобразитиВБухгалтерськомуОбліку;

        // Таблична частина "РозрахункиЗКонтрагентами" 
        РозрахункиЗКонтрагентами.ЕлементВласник = Елемент;
        await РозрахункиЗКонтрагентами.LoadRecords();

        // Таблична частина "Проводки" 
        Проводки.ЕлементВласник = Елемент;
        await Проводки.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.Організація = Організація.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Основа = Основа.Pointer;
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
                await РозрахункиЗКонтрагентами.SaveRecords(); // Таблична частина "РозрахункиЗКонтрагентами"
                await Проводки.SaveRecords(); // Таблична частина "Проводки"

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
        CommonForms_DocumentMovementThroughRegisters.Create(new КорегуванняБоргу_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
