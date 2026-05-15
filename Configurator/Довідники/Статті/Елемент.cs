
/*
        Статті_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_QBZ4LTJGKUiICZgInCNuvg")]
partial class Статті_Елемент : DirectoryFormElement
{
    public Статті_Objest Елемент { get; init; } = new();

    public Статті_Pointer РодичДляНового { get; set; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Статті_PointerControl Родич = Статті_PointerControl.New();
    Label ЦеПапкаНазва = Label.New("");
    Switch ЦеПапка = Switch.New();
    Entry КодЗПодатковоїДекларації = Entry.New();

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
        ЦеПапка.Sensitive = false;
        ЦеПапка.OnStateSet += (_, _) =>
        {
            ВстановитиДоступністьПолів();
            return false;
        };

        // КодЗПодатковоїДекларації:
        КодЗПодатковоїДекларації.WidthRequest = 300;
    }

    public static Статті_Елемент New()
    {
        Статті_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // ЦеГрупа
        CreateField(CreateField(vBox, null, ЦеПапкаНазва), null, ЦеПапка);

        CreateCaptionLink(vBox, "Спільні реквізити для груп та елементів");

        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Родич
        CreateField(vBox, null, Родич);
    }

    protected override void CreateEnd(Box vBox)
    {
        CreateCaptionLink(vBox, "Реквізити для елементів");

        // КодЗПодатковоїДекларації
        CreateField(vBox, "Код з податкової декларації:", КодЗПодатковоїДекларації, Align.Start);
    }

    #region Присвоєння / зчитування значень

    void ВстановитиДоступністьПолів()
    {
        bool visible = ЦеПапка.Active;
        ЦеПапкаНазва.SetText("Це " + (visible ? "група" : "елемент"));

        КодЗПодатковоїДекларації.Sensitive = !visible;
    }

    public override async ValueTask AssignValue()
    {
        if (IsNew)
        {
            Елемент.Родич = РодичДляНового;
            ЦеПапка.Sensitive = true;
        }
        else
            Родич.OpenFolder = Елемент.UniqueID;

        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        Родич.Pointer = Елемент.Родич;
        ЦеПапка.Active = Елемент.ЦеПапка;
        КодЗПодатковоїДекларації.SetText(Елемент.КодЗПодатковоїДекларації);

        ВстановитиДоступністьПолів();
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.Родич = Родич.Pointer;
        Елемент.ЦеПапка = ЦеПапка.Active;
        Елемент.КодЗПодатковоїДекларації = КодЗПодатковоїДекларації.GetText();
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
