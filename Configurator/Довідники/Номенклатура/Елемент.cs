
/*
        Номенклатура_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Номенклатура_Елемент : DirectoryFormElement
{
    public Номенклатура_Objest Елемент { get; init; } = new Номенклатура_Objest();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    Entry Код = new() { WidthRequest = 100 };
                    Entry НазваПовна = new() { WidthRequest = 500 };
                    TextView Опис = new TextView() { WrapMode = WrapMode.Word };
                    Entry Артикул = new() { WidthRequest = 500 };
                    ComboBoxText ТипНоменклатури = new ComboBoxText();
            Виробники_PointerControl Виробник = new() { Caption = "Виробник", WidthPresentation = 500 };
            ВидиНоменклатури_PointerControl ВидНоменклатури = new() { Caption = "ВидНоменклатури", WidthPresentation = 500 };
            ПакуванняОдиниціВиміру_PointerControl ОдиницяВиміру = new() { Caption = "ОдиницяВиміру", WidthPresentation = 500 };
            Номенклатура_Папки_PointerControl Папка = new() { Caption = "Папка", WidthPresentation = 500 };
            Файли_PointerControl ОсновнаКартинкаФайл = new() { Caption = "ОсновнаКартинкаФайл", WidthPresentation = 500 };
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Файли"
        Номенклатура_ТабличнаЧастина_Файли Файли = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public Номенклатура_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипиНоменклатури_List())
                ТипНоменклатури.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ТипНоменклатури.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Код
            CreateField(vBox, "Код:", Код);
                        
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
            CreateTablePart(vBox, "Файли:", Файли);
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Назва.SetText(Елемент.Назва);
                        Код.SetText(Елемент.Код);
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
        Елемент.Назва = Назва.GetText();
                        Елемент.Код = Код.GetText();
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
    