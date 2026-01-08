
/*

        ПоступленняТоварівТаПослуг_Елемент.cs
        Елемент

*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode;
using GeneratedCode.Константи;
using GeneratedCode.Документи;
using Перелічення = GeneratedCode.Перелічення;

namespace StorageAndTrade
{
    class ПоступленняТоварівТаПослуг_Елемент : DocumentElement
    {
        public ПоступленняТоварівТаПослуг_Objest Елемент { get; init; } = new ПоступленняТоварівТаПослуг_Objest();

        #region Fields

        Entry НомерДок = new Entry() { WidthRequest = 100 };
        Entry НомерДок1 = new Entry() { WidthRequest = 300 };
        Entry НомерДок2 = new Entry() { WidthRequest = 300 };
        Entry НомерДок3 = new Entry() { WidthRequest = 300 };
        DateTimeControl ДатаДок = new DateTimeControl();
        Entry Коментар = new Entry() { WidthRequest = 1200 };
        CompositePointerControl Основа = new() { BoundConfType = "Документи.ПоступленняТоварівТаПослуг.Основа" };

        ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари Товари = new() { HeightRequest = 400 };

        #endregion

        public ПоступленняТоварівТаПослуг_Елемент() : base(Program.BasicForm?.NotebookFunc)
        {
            Element = Елемент;

            CreateDocName(ПоступленняТоварівТаПослуг_Const.FULLNAME, НомерДок, ДатаДок);
            CreateField(HBoxComment, "Коментар:", Коментар);

            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            NotebookTablePart.SetCurrentPage(0);
        }

        protected override void CreateTopStartBloc(Box vBox)
        {
            CreateField(vBox, "НомерДок 1", НомерДок1);
        }

        protected override void CreateTopEndBloc(Box vBox)
        {
            CreateField(vBox, "НомерДок 2", НомерДок2);
        }

        protected override void CreateBottomStartBloc(Box vBox)
        {
            //Основа
            CreateField(vBox, null, Основа);
        }

        protected override void CreateBottomEndBloc(Box vBox)
        {
            CreateField(vBox, "НомерДок 3", НомерДок3);
        }

        #region Присвоєння / зчитування значень

        public override async ValueTask BeforeSetValue()
        {
            if (IsNew)
            {

            }

            НомерДок.SetText(Елемент.НомерДок);
            ДатаДок.Value = Елемент.ДатаДок;
            Коментар.SetText(Елемент.Коментар);
            Основа.Pointer = Елемент.Основа;

            Товари.ЕлементВласник = Елемент;
            await Товари.LoadRecords();
        }

        protected override void GetValue()
        {
            Елемент.НомерДок = НомерДок.GetText();
            Елемент.ДатаДок = ДатаДок.Value;
            Елемент.Коментар = Коментар.GetText();
            Елемент.Основа = Основа.Pointer;
        }

        #endregion

        protected override async ValueTask<bool> Save()
        {
            bool isSave = false;

            try
            {
                if (await Елемент.Save())
                {
                    await Товари.SaveRecords();
                    isSave = true;
                }
            }
            catch /*(Exception ex)*/
            {

            }

            return isSave;
        }

        protected override async ValueTask<bool> SpendTheDocument(bool spendDoc)
        {
            if (spendDoc)
            {
                bool isSpend = await Елемент.SpendTheDocument(Елемент.ДатаДок);

                // if (!isSpend)
                //     ФункціїДляПовідомлень.ПоказатиПовідомлення(Елемент.UnigueID);

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
            //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ПоступленняТоварівТаПослуг_Pointer(unigueID));
        }

        protected override async ValueTask InJournal(UnigueID unigueID)
        {
            /*ПоступленняТоварівТаПослуг page = new ПоступленняТоварівТаПослуг() { SelectPointerItem = unigueID };
            NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, ПоступленняТоварівТаПослуг_Const.FULLNAME, () => page);
            await page.SetValue();*/
        }
    }
}