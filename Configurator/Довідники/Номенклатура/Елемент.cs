
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
    public Номенклатура_Objest Елемент { get; init; } = new();
    
    #region Fields
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 300 };
                    Entry НазваПовна = new() { WidthRequest = 300 };
                    TextView Опис = new TextView() { WrapMode = WrapMode.Word };
                    Entry Артикул = new() { WidthRequest = 300 };
                    ComboBoxText ТипНоменклатури = new ComboBoxText();
            Виробники_PointerControl Виробник = new() { Caption = "Виробник", WidthPresentation = 300 };
            ВидиНоменклатури_PointerControl ВидНоменклатури = new() { Caption = "ВидНоменклатури", WidthPresentation = 300 };
            ПакуванняОдиниціВиміру_PointerControl ОдиницяВиміру = new() { Caption = "ОдиницяВиміру", WidthPresentation = 300 };
            Номенклатура_Папки_PointerControl Папка = new() { Caption = "Папка", WidthPresentation = 300 };
            Файли_PointerControl ОсновнаКартинкаФайл = new() { Caption = "ОсновнаКартинкаФайл", WidthPresentation = 300 };
            
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
            CreateTablePart(vBox, "Файли:", Файли);
        
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
    