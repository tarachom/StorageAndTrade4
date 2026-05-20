
/*
        Категорії_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_9hAhQS5xLkGxSrQ4MEw9w")]
partial class Категорії_Елемент : DirectoryFormElement
{
    public Категорії_Objest Елемент { get; init; } = new();

    public Категорії_Pointer РодичДляНового { get; set; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Категорії_PointerControl Родич = Категорії_PointerControl.New();
    ComboBoxText МетодСписання = ComboBoxText.New();
    ПланРахунків_PointerControl РахунокОбліку = ПланРахунків_PointerControl.New();
    ПланРахунків_PointerControl РахунокДоходів = ПланРахунків_PointerControl.New();
    Статті_PointerControl СтаттяДоходів = Статті_PointerControl.New();
    ПланРахунків_PointerControl РахунокВитрат = ПланРахунків_PointerControl.New();
    Статті_PointerControl СтаттяВитрат = Статті_PointerControl.New();

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

        // МетодСписання:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.МетодиСписання_List())
                МетодСписання.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            МетодСписання.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

        // РахунокОбліку:
        РахунокОбліку.Caption = "Рахунок обліку";
        РахунокОбліку.WidthPresentation = 300;
        РахунокОбліку.AllowedContentSelection = ConfigurationDirectories.HierarchicalContentType.Elements;
        РахунокОбліку.WhereList =
        [
            new(ПланРахунків_Const.Код, Comparison.EQ, "20"),
            new(Comparison.OR, ПланРахунків_Const.Код, Comparison.EQ, "26"),
            new(Comparison.OR, ПланРахунків_Const.Код, Comparison.EQ, "28")
        ];

        // РахунокДоходів:
        РахунокДоходів.Caption = "Рахунок доходів";
        РахунокДоходів.WidthPresentation = 300;
        РахунокДоходів.AllowedContentSelection = ConfigurationDirectories.HierarchicalContentType.Elements;
        РахунокДоходів.WhereList =
        [
            new(ПланРахунків_Const.Код, Comparison.EQ, "701"),
            new(Comparison.OR, ПланРахунків_Const.Код, Comparison.EQ, "702"),
            new(Comparison.OR, ПланРахунків_Const.Код, Comparison.EQ, "703")
        ];

        // СтаттяДоходів:
        СтаттяДоходів.Caption = "Стаття доходів";
        СтаттяДоходів.WidthPresentation = 300;
        СтаттяДоходів.AllowedContentSelection = ConfigurationDirectories.HierarchicalContentType.Elements;

        // РахунокВитрат:
        РахунокВитрат.Caption = "Рахунок витрат";
        РахунокВитрат.WidthPresentation = 300;
        РахунокВитрат.AllowedContentSelection = ConfigurationDirectories.HierarchicalContentType.Elements;
        РахунокВитрат.WhereList =
        [
            new(ПланРахунків_Const.Код, Comparison.EQ, "901"),
            new(Comparison.OR, ПланРахунків_Const.Код, Comparison.EQ, "902"),
            new(Comparison.OR, ПланРахунків_Const.Код, Comparison.EQ, "903")
        ];

        // СтаттяВитрат:
        СтаттяВитрат.Caption = "Стаття витрат";
        СтаттяВитрат.WidthPresentation = 300;
        СтаттяВитрат.AllowedContentSelection = ConfigurationDirectories.HierarchicalContentType.Elements;
    }

    public static Категорії_Елемент New()
    {
        Категорії_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Родич
        CreateField(vBox, null, Родич);

        // МетодСписання
        CreateField(vBox, "Метод списання:", МетодСписання);

        // РахунокОбліку
        CreateField(vBox, null, РахунокОбліку);

        // РахунокДоходів
        CreateField(vBox, null, РахунокДоходів);

        // СтаттяДоходів
        CreateField(vBox, null, СтаттяДоходів);

        // РахунокВитрат
        CreateField(vBox, null, РахунокВитрат);

        // СтаттяВитрат
        CreateField(vBox, null, СтаттяВитрат);
    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        if (IsNew)
            Елемент.Родич = РодичДляНового;
        else
            Родич.OpenFolder = Елемент.UniqueID;

        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        Родич.Pointer = Елемент.Родич;
        МетодСписання.ActiveId = Елемент.МетодСписання.ToString();
        РахунокОбліку.Pointer = Елемент.РахунокОбліку;
        РахунокДоходів.Pointer = Елемент.РахунокДоходів;
        СтаттяДоходів.Pointer = Елемент.СтаттяДоходів;
        РахунокВитрат.Pointer = Елемент.РахунокВитрат;
        СтаттяВитрат.Pointer = Елемент.СтаттяВитрат;
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.Родич = Родич.Pointer;
        Елемент.МетодСписання = ПсевдонімиПерелічення.МетодиСписання_FindByName(МетодСписання.ActiveId);
        Елемент.РахунокОбліку = РахунокОбліку.Pointer;
        Елемент.РахунокДоходів = РахунокДоходів.Pointer;
        Елемент.СтаттяДоходів = СтаттяДоходів.Pointer;
        Елемент.РахунокВитрат = РахунокВитрат.Pointer;
        Елемент.СтаттяВитрат = СтаттяВитрат.Pointer;
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
