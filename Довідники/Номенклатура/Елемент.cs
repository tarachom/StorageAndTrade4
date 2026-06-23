
/*
        Номенклатура_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;
using GeneratedCode.Константи;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_S9bRrUmiOE6Oasw7xLAeIA")]
partial class Номенклатура_Елемент : DirectoryFormElement
{
    public Номенклатура_Object Елемент { get; init; } = new();
    public Номенклатура_Папки_Pointer РодичДляНового { get; set; } = new Номенклатура_Папки_Pointer();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Entry НазваПовна = Entry.New();
    TextView Опис = TextView.New();
    Entry Артикул = Entry.New();
    ComboBoxText ТипНоменклатури = ComboBoxText.New();
    Виробники_PointerControl Виробник = Виробники_PointerControl.New();
    ВидиНоменклатури_PointerControl ВидНоменклатури = ВидиНоменклатури_PointerControl.New();
    ПакуванняОдиниціВиміру_PointerControl ОдиницяВиміру = ПакуванняОдиниціВиміру_PointerControl.New();
    Номенклатура_Папки_PointerControl Папка = Номенклатура_Папки_PointerControl.New();
    Файли_PointerControl ОсновнаКартинкаФайл = Файли_PointerControl.New();
    Категорії_PointerControl Категорія = Категорії_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Файли"
    Номенклатура_ТабличнаЧастина_Файли Файли = Номенклатура_ТабличнаЧастина_Файли.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Код:
        Код.WidthRequest = 100;

        // Назва:
        Назва.WidthRequest = 500;

        // НазваПовна:
        НазваПовна.WidthRequest = 500;

        // Опис:
        Опис.WrapMode = WrapMode.Word;

        // Артикул:
        Артикул.WidthRequest = 500;

        // ТипНоменклатури:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипиНоменклатури_List())
                ТипНоменклатури.Append(field.Value.ToString(), field.Name);

            ТипНоменклатури.Active = 0;
            ТипНоменклатури.AddController(FunctionForComboBox.DisableScrolling());
        }

        // Виробник:
        Виробник.Caption = "Виробник";
        Виробник.WidthPresentation = 300;

        // ВидНоменклатури:
        ВидНоменклатури.Caption = "Вид";
        ВидНоменклатури.WidthPresentation = 250;

        // ОдиницяВиміру:
        ОдиницяВиміру.Caption = "Одиниця виміру";
        ОдиницяВиміру.WidthPresentation = 300;

        // Папка:
        Папка.Caption = "Папка";
        Папка.WidthPresentation = 300;

        // ОсновнаКартинкаФайл:
        ОсновнаКартинкаФайл.Caption = "Основна картинка";
        ОсновнаКартинкаФайл.WidthPresentation = 300;

        // Категорія:
        Категорія.Caption = "Категорія";
        Категорія.WidthPresentation = 400;
    }

    public static Номенклатура_Елемент New()
    {
        Номенклатура_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DirectoryElement Interface;

    protected override void BuildInterface()
    {
        Interface = FunctionForInterfaces.ForDirectory();

        Append(Interface.MainBox);
        CreateStart(Interface.TopStartBox);
        CreateEnd(Interface.TopEndBox);
    }

    void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Папка
        CreateField(vBox, null, Папка);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // НазваПовна
        CreateField(vBox, "Назва повна:", НазваПовна);

        // Артикул
        CreateField(vBox, "Артикул:", Артикул);

        {
            // ТипНоменклатури
            Box hBox = CreateField(vBox, "Тип:", ТипНоменклатури);

            // ВидНоменклатури
            CreateField(hBox, null, ВидНоменклатури);
        }

        // ОдиницяВиміру
        CreateField(vBox, null, ОдиницяВиміру);

        // Виробник
        CreateField(vBox, null, Виробник);

        // Опис
        CreateFieldView(vBox, "Опис:", Опис, 500, 200);

        CreateCaptionLink(vBox, "Для бухгалтерії");

        // Категорія
        CreateField(vBox, null, Категорія);
    }

    void CreateEnd(Box vBox)
    {
        // Таблична частина "Файли"
        Файли.WidthRequest = 500;
        Файли.HeightRequest = 300;
        Файли.Vexpand = false;

        CreateTablePart(vBox, "Файли", Файли);

        // ОсновнаКартинкаФайл
        CreateField(vBox, null, ОсновнаКартинкаФайл, Align.Start);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Папка = РодичДляНового;
            Елемент.ТипНоменклатури = ТипиНоменклатури.Товар;

            Елемент.ОдиницяВиміру = await ЗначенняТипові.ОсновнаОдиницяПакування();
            Елемент.ВидНоменклатури = await ЗначенняТипові.ОсновнийВидНоменклатури();
        }

        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        НазваПовна.SetText(Елемент.НазваПовна);
        Опис.Buffer?.Text = Елемент.Опис;
        Артикул.SetText(Елемент.Артикул);
        ТипНоменклатури.ActiveId = Елемент.ТипНоменклатури.ToString();
        Виробник.Pointer = Елемент.Виробник;
        ВидНоменклатури.Pointer = Елемент.ВидНоменклатури;
        ОдиницяВиміру.Pointer = Елемент.ОдиницяВиміру;
        Папка.Pointer = Елемент.Папка;
        ОсновнаКартинкаФайл.Pointer = Елемент.ОсновнаКартинкаФайл;
        Категорія.Pointer = Елемент.Категорія;

        // Таблична частина "Файли"
        Файли.ЕлементВласник = Елемент;
        await Файли.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.НазваПовна = НазваПовна.GetText();
        Елемент.Опис = Опис.Buffer?.Text ?? "";
        Елемент.Артикул = Артикул.GetText();
        Елемент.ТипНоменклатури = ПсевдонімиПерелічення.ТипиНоменклатури_FindByName(ТипНоменклатури.ActiveId);
        Елемент.Виробник = Виробник.Pointer;
        Елемент.ВидНоменклатури = ВидНоменклатури.Pointer;
        Елемент.ОдиницяВиміру = ОдиницяВиміру.Pointer;
        Елемент.Папка = Папка.Pointer;
        Елемент.ОсновнаКартинкаФайл = ОсновнаКартинкаФайл.Pointer;
        Елемент.Категорія = Категорія.Pointer;
    }

    #endregion

    protected override async Task<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await Файли.SaveRecords(); // Таблична частина "Файли"
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
