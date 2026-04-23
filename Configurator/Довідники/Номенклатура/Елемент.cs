
/*
        Номенклатура_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_Qoth98oOUe3zLMJ2rWRfQ")]
partial class Номенклатура_Елемент : DirectoryFormElement
{
    public Номенклатура_Objest Елемент { get; init; } = new();
    
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
            Назва.WidthRequest = 300;
                        
            // НазваПовна:
            НазваПовна.WidthRequest = 300;
                        
            // Опис:
            Опис.WrapMode = WrapMode.Word;
                        
            // Артикул:
            Артикул.WidthRequest = 300;
                        
            // ТипНоменклатури:
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.ТипиНоменклатури_List())
                    ТипНоменклатури.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                ТипНоменклатури.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                
            // Виробник:
            Виробник.Caption = "Виробник";
                    Виробник.WidthPresentation = 300;
                
            // ВидНоменклатури:
            ВидНоменклатури.Caption = "ВидНоменклатури";
                    ВидНоменклатури.WidthPresentation = 300;
                
            // ОдиницяВиміру:
            ОдиницяВиміру.Caption = "ОдиницяВиміру";
                    ОдиницяВиміру.WidthPresentation = 300;
                
            // Папка:
            Папка.Caption = "Папка";
                    Папка.WidthPresentation = 300;
                
            // ОсновнаКартинкаФайл:
            ОсновнаКартинкаФайл.Caption = "ОсновнаКартинкаФайл";
                    ОсновнаКартинкаФайл.WidthPresentation = 300;
                
    }

    public static Номенклатура_Елемент New()
    {
        Номенклатура_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // НазваПовна
            CreateField(vBox, "НазваПовна:", НазваПовна);
                        
            // Опис
            CreateFieldView(vBox, "Опис:", Опис, 500, 200);
                        
            // Артикул
            CreateField(vBox, "Артикул:", Артикул);
                        
            // ТипНоменклатури
            CreateField(vBox, "ТипНоменклатури:", ТипНоменклатури);
                
            // Виробник
            CreateField(vBox, null, Виробник);
                
            // ВидНоменклатури
            CreateField(vBox, null, ВидНоменклатури);
                
            // ОдиницяВиміру
            CreateField(vBox, null, ОдиницяВиміру);
                
            // Папка
            CreateField(vBox, null, Папка);
                
            // ОсновнаКартинкаФайл
            CreateField(vBox, null, ОсновнаКартинкаФайл);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
            // Таблична частина "Файли"
            Файли.WidthRequest = 500;
            Файли.HeightRequest = 300;
            CreateTablePart(vBox, "Файли", Файли);
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
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
                
    }

    #endregion

    protected override async ValueTask<bool> Save()
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
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    