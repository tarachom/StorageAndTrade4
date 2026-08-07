
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
    КласифікаторОдиницьВиміру_PointerControl БазоваОдиницяВиміру = КласифікаторОдиницьВиміру_PointerControl.New();
    ПакуванняОдиниціВиміру_PointerControl ОдиницяВиміру = ПакуванняОдиниціВиміру_PointerControl.New();
    ПакуванняОдиниціВиміру_PointerControl ОдиницяДляЗвітів = ПакуванняОдиниціВиміру_PointerControl.New();
    Номенклатура_Папки_PointerControl Папка = Номенклатура_Папки_PointerControl.New();
    Файли_PointerControl ОсновнаКартинкаФайл = Файли_PointerControl.New();
    Категорії_PointerControl Категорія = Категорії_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Файли"
    Номенклатура_ТабличнаЧастина_Файли Файли = Номенклатура_ТабличнаЧастина_Файли.New();

    #endregion

    #region Списки

    ПакуванняОдиниціВиміру_ШвидкийВибір ОдиниціВиміруСписок = ПакуванняОдиниціВиміру_ШвидкийВибір.New();

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

        // БазоваОдиницяВиміру:
        БазоваОдиницяВиміру.Caption = "Базова одиниця виміру";
        БазоваОдиницяВиміру.WidthPresentation = 300;

        // ОдиницяВиміру:
        ОдиницяВиміру.Caption = "Одиниця виміру для залишків";
        ОдиницяВиміру.WidthPresentation = 300;

        // ОдиницяДляЗвітів:
        ОдиницяДляЗвітів.Caption = "Одиниця виміру для звітів";
        ОдиницяДляЗвітів.WidthPresentation = 300;

        // Папка:
        Папка.Caption = "Папка";
        Папка.WidthPresentation = 300;

        // ОсновнаКартинкаФайл:
        ОсновнаКартинкаФайл.Caption = "Основна картинка";
        ОсновнаКартинкаФайл.WidthPresentation = 300;

        // Категорія:
        Категорія.Caption = "Категорія";
        Категорія.WidthPresentation = 400;

        // Таблична частина "Файли"
        Файли.ЕлементВласник = Елемент;
        Файли.WidthRequest = 500;
        Файли.HeightRequest = 300;
        Файли.Vexpand = false;

        //  ОдиниціяВиміруСписок
        ОдиниціВиміруСписок.WidthRequest = 500;
        ОдиниціВиміруСписок.HeightRequest = 300;
        ОдиниціВиміруСписок.Vexpand = false;
        ОдиниціВиміруСписок.ПриховатиЕлементиФорми();
    }

    public static Номенклатура_Елемент New()
    {
        Номенклатура_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DirectoryElement Interface = FunctionForInterfaces.ForDirectory();

    protected override void BuildInterface()
    {
        Append(Interface.MainBox);
        CreateStart(Interface.TopStartBox);
        CreateEnd(Interface.TopEndBox);
    }

    void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // НазваПовна
        CreateField(vBox, "Назва повна:", НазваПовна);

        // Папка
        CreateField(vBox, null, Папка);

        // Артикул
        CreateField(vBox, "Артикул:", Артикул);

        {
            // ТипНоменклатури
            Box hBox = CreateField(vBox, "Тип:", ТипНоменклатури);

            // ВидНоменклатури
            CreateField(hBox, null, ВидНоменклатури);
        }

        // БазоваОдиницяВиміру
        CreateField(vBox, null, БазоваОдиницяВиміру);

        // ОдиницяВиміру
        CreateField(vBox, null, ОдиницяВиміру);

        // ОдиницяДляЗвітів
        CreateField(vBox, null, ОдиницяДляЗвітів);

        // Виробник
        CreateField(vBox, null, Виробник);

        // Опис
        CreateFieldView(vBox, "Опис:", Опис, 500, 200);

        //ОсновнаКартинкаФайл
        CreateField(vBox, null, ОсновнаКартинкаФайл);

        CreateCaptionLink(vBox, "Для бухгалтерії");

        // Категорія
        CreateField(vBox, null, Категорія);
    }

    void CreateEnd(Box vBox)
    {
        //Одиниці виміру
        CreateTablePart(vBox, "Одиниці виміру", ОдиниціВиміруСписок);

        //Файли
        CreateTablePart(vBox, "Файли", Файли);        
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
            Елемент.Папка = РодичДляНового;

        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        НазваПовна.SetText(Елемент.НазваПовна);
        Опис.Buffer?.Text = Елемент.Опис;
        Артикул.SetText(Елемент.Артикул);
        ТипНоменклатури.ActiveId = Елемент.ТипНоменклатури.ToString();
        Виробник.Pointer = Елемент.Виробник;
        ВидНоменклатури.Pointer = Елемент.ВидНоменклатури;
        БазоваОдиницяВиміру.Pointer = Елемент.БазоваОдиницяВиміру;
        ОдиницяВиміру.Pointer = Елемент.ОдиницяВиміру;
        ОдиницяДляЗвітів.Pointer = Елемент.ОдиницяДляЗвітів;
        Папка.Pointer = Елемент.Папка;
        ОсновнаКартинкаФайл.Pointer = Елемент.ОсновнаКартинкаФайл;
        Категорія.Pointer = Елемент.Категорія;

        // Таблична частина "Файли"
        await Файли.LoadRecords();

        ОдиницяВиміру.Власник = Елемент.GetDirectoryPointer();
        ОдиницяДляЗвітів.Власник = Елемент.GetDirectoryPointer();
        ОдиниціВиміруСписок.Власник.Pointer = Елемент.GetDirectoryPointer();

        //Завантаження списку
        await ОдиниціВиміруСписок.SetValue();
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
        Елемент.БазоваОдиницяВиміру = БазоваОдиницяВиміру.Pointer;
        Елемент.ОдиницяВиміру = ОдиницяВиміру.Pointer;
        Елемент.ОдиницяДляЗвітів = ОдиницяДляЗвітів.Pointer;
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
                
                //Перевантаження списку одиниць виміру
                await ОдиниціВиміруСписок.LoadRecords();

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
