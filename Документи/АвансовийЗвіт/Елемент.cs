
/*
        АвансовийЗвіт_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Константи;
using GeneratedCode.Документи;
using Функції = StorageAndTrade.АвансовийЗвіт_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_lpaeAS98yHtJBlH9nFJbg")]
partial class АвансовийЗвіт_Елемент : DocumentFormElement
{
    public АвансовийЗвіт_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    ФізичніОсоби_PointerControl ФізичнаОсоба = ФізичніОсоби_PointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Entry ПризначенняАвансу = Entry.New();
    ВидиЦін_PointerControl ВидЦіни = ВидиЦін_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    CheckButton ВідобразитиВБухгалтерськомуОбліку = CheckButton.NewWithLabel("Відобразити в бух обліку");

    #endregion

    #region TabularParts

    // Таблична частина "ВиданіАванси" 
    АвансовийЗвіт_ТабличнаЧастина_ВиданіАванси ВиданіАванси = АвансовийЗвіт_ТабличнаЧастина_ВиданіАванси.New();

    // Таблична частина "Проводки" 
    АвансовийЗвіт_ТабличнаЧастина_Проводки Проводки = АвансовийЗвіт_ТабличнаЧастина_Проводки.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(АвансовийЗвіт_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxTop, null, ВідобразитиВБухгалтерськомуОбліку);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "ВиданіАванси"
        ВиданіАванси.HeightRequest = 300;
        Interface.Notebook.InsertPage(ВиданіАванси, Label.New("Видані аванси"), 0);

        // Таблична частина "Проводки"
        Проводки.HeightRequest = 300;
        Interface.Notebook.InsertPage(Проводки, Label.New("Проводки"), 1);

        Interface.Notebook.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Основа:
        Основа.BoundConfType = "Документи.АвансовийЗвіт.Основа";

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //ФізичнаОсоба:
        ФізичнаОсоба.Caption = "Фізична особа";
        ФізичнаОсоба.WidthPresentation = 300;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //ПризначенняАвансу:
        ПризначенняАвансу.WidthRequest = 300;

        //ВидЦіни:
        ВидЦіни.Caption = "ВидЦіни";
        ВидЦіни.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;
    }

    public static АвансовийЗвіт_Елемент New()
    {
        АвансовийЗвіт_Елемент element = NewWithProperties([]);
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

        // ФізичнаОсоба
        CreateField(vBox, null, ФізичнаОсоба);
    }

    void CreateTopEnd(Box vBox)
    {
        // ПризначенняАвансу
        CreateField(vBox, "Призначення авансу:", ПризначенняАвансу);
    }

    void CreateBottomStart(Box vBox)
    {
        // Валюта
        CreateField(vBox, null, Валюта);

        // Автор
        CreateField(vBox, null, Автор);

        // Підрозділ
        CreateField(vBox, null, Підрозділ);
    }

    void CreateBottomEnd(Box vBox)
    {
        // ВидЦіни
        CreateField(vBox, null, ВидЦіни);

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
            Елемент.Валюта = await ЗначенняТипові.ОсновнаВалюта();
            Елемент.Підрозділ = await ЗначенняТипові.ОсновнийПідрозділ();
        }

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Коментар.SetText(Елемент.Коментар);
        Основа.Pointer = Елемент.Основа;
        Організація.Pointer = Елемент.Організація;
        Валюта.Pointer = Елемент.Валюта;
        ФізичнаОсоба.Pointer = Елемент.ФізичнаОсоба;
        Автор.Pointer = Елемент.Автор;
        ПризначенняАвансу.Buffer?.Text = Елемент.ПризначенняАвансу;
        ВидЦіни.Pointer = Елемент.ВидЦіни;
        Підрозділ.Pointer = Елемент.Підрозділ;
        ВідобразитиВБухгалтерськомуОбліку.Active = Елемент.ВідобразитиВБухгалтерськомуОбліку;

        // Таблична частина "ВиданіАванси" 
        ВиданіАванси.ЕлементВласник = Елемент;
        await ВиданіАванси.LoadRecords();

        // Таблична частина "Проводки" 
        Проводки.ЕлементВласник = Елемент;
        await Проводки.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Основа = Основа.Pointer;
        Елемент.Організація = Організація.Pointer;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.ФізичнаОсоба = ФізичнаОсоба.Pointer;
        Елемент.Автор = Автор.Pointer;
        Елемент.ПризначенняАвансу = ПризначенняАвансу.Buffer?.Text ?? "";
        Елемент.ВидЦіни = ВидЦіни.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.ВідобразитиВБухгалтерськомуОбліку = ВідобразитиВБухгалтерськомуОбліку.Active;

        Елемент.СумаДокументу = ВиданіАванси.СумаДокументу();
    }

    #endregion

    protected override async Task<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await ВиданіАванси.SaveRecords(); // Таблична частина "ВиданіАванси"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new АвансовийЗвіт_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
