
/*
        ПланРахунків_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_iEP5X7rPMEuR2U0CC77uwQ")]
partial class ПланРахунків_Елемент : DirectoryFormElement
{
    public ПланРахунків_Objest Елемент { get; init; } = new();

    public ПланРахунків_Pointer РодичДляНового { get; set; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    ПланРахунків_PointerControl Родич = ПланРахунків_PointerControl.New();
    Label ЦеГрупаНазва = Label.New("");
    Switch ЦеГрупа = Switch.New();
    CheckButton Сумовий = CheckButton.NewWithLabel("Сумовий");
    CheckButton Кількісний = CheckButton.NewWithLabel("Кількісний");
    CheckButton Валютний = CheckButton.NewWithLabel("Валютний");
    CheckButton Забалансовий = CheckButton.NewWithLabel("Забалансовий");
    Entry Субконто1 = Entry.New();
    Entry Субконто2 = Entry.New();
    Entry Субконто3 = Entry.New();
    IntegerControl Клас = IntegerControl.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Код:
        Код.WidthRequest = 100;

        // Назва:
        Назва.WidthRequest = 500;

        // Родич:
        Родич.Caption = "Група";
        Родич.WidthPresentation = 300;
        Родич.AllowedContentSelection = ConfigurationDirectories.HierarchicalContentType.Folders;

        // ЦеГрупа
        ЦеГрупа.Sensitive = false;
        ЦеГрупа.OnStateSet += (_, _) =>
        {
            ВстановитиДоступністьПолів();
            return false;
        };

        //Субконто1
        Субконто1.WidthRequest = 500;

        //Субконто2
        Субконто2.WidthRequest = 500;

        //Субконто3
        Субконто3.WidthRequest = 500;
    }

    public static ПланРахунків_Елемент New()
    {
        ПланРахунків_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // ЦеГрупа
        CreateField(CreateField(vBox, null, ЦеГрупаНазва), null, ЦеГрупа);

        CreateCaptionLink(vBox, "Спільні реквізити для груп та елементів");

        {
            // Код
            Box hBox = CreateField(vBox, "Код:", Код);

            // Клас
            CreateField(hBox, "Клас:", Клас);
        }

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Родич
        CreateField(vBox, null, Родич);
    }

    protected override void CreateEnd(Box vBox)
    {
        CreateCaptionLink(vBox, "Реквізити для елементів");

        {
            // Сумовий
            Box hBox = CreateField(vBox, null, Сумовий, Align.Start);

            // Кількісний
            CreateField(hBox, null, Кількісний);

            // Валютний
            CreateField(hBox, null, Валютний);

            // Забалансовий
            CreateField(hBox, null, Забалансовий);
        }

        // Субконто1
        CreateField(vBox, "Субконто 1:", Субконто1, Align.Start);

        // Субконто2
        CreateField(vBox, "Субконто 2:", Субконто2, Align.Start);

        // Субконто3
        CreateField(vBox, "Субконто 3:", Субконто3, Align.Start);
    }

    #region Присвоєння / зчитування значень

    void ВстановитиДоступністьПолів()
    {
        bool visible = ЦеГрупа.Active;
        ЦеГрупаНазва.SetText("Це " + (visible ? "група" : "елемент"));

        Сумовий.Sensitive = !visible;
        Кількісний.Sensitive = !visible;
        Валютний.Sensitive = !visible;
        Забалансовий.Sensitive = !visible;
        Субконто1.Sensitive = !visible;
        Субконто2.Sensitive = !visible;
        Субконто3.Sensitive = !visible;
    }

    public override async ValueTask AssignValue()
    {
        if (IsNew)
        {
            Елемент.Родич = РодичДляНового;
            ЦеГрупа.Sensitive = true;
        }
        else
            Родич.OpenFolder = Елемент.UniqueID;

        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        Родич.Pointer = Елемент.Родич;
        ЦеГрупа.Active = Елемент.ЦеГрупа;
        Сумовий.Active = Елемент.Сумовий;
        Кількісний.Active = Елемент.Кількісний;
        Валютний.Active = Елемент.Валютний;
        Забалансовий.Active = Елемент.Забалансовий;
        Субконто1.SetText(Елемент.Субконто1);
        Субконто2.SetText(Елемент.Субконто2);
        Субконто3.SetText(Елемент.Субконто3);
        Клас.Value = Елемент.Клас;

        ВстановитиДоступністьПолів();
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.Родич = Родич.Pointer;
        Елемент.ЦеГрупа = ЦеГрупа.Active;
        Елемент.Сумовий = Сумовий.Active;
        Елемент.Кількісний = Кількісний.Active;
        Елемент.Валютний = Валютний.Active;
        Елемент.Забалансовий = Забалансовий.Active;
        Елемент.Субконто1 = Субконто1.GetText();
        Елемент.Субконто2 = Субконто2.GetText();
        Елемент.Субконто3 = Субконто3.GetText();
        Елемент.Клас = Клас.Value;
    }

    #endregion

    protected override async ValueTask<bool> Save()
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
}
