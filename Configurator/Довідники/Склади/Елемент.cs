
/*
        Склади_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Склади_Елемент : DirectoryFormElement
{
    public Склади_Objest Елемент { get; init; } = new Склади_Objest();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
                    Entry Код = new() { WidthRequest = 500 };
                    ComboBoxText ТипСкладу = new ComboBoxText();
            ФізичніОсоби_PointerControl Відповідальний = new() { Caption = "Відповідальний", WidthPresentation = 500 };
            ВидиЦін_PointerControl ВидЦін = new() { Caption = "ВидЦін", WidthPresentation = 500 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 500 };
            Склади_Папки_PointerControl Папка = new() { Caption = "Папка", WidthPresentation = 500 };
            ComboBoxText НалаштуванняАдресногоЗберігання = new ComboBoxText();
            Entry КлючовіСловаДляПошуку = new() { WidthRequest = 500 };
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Контакти"
        Склади_ТабличнаЧастина_Контакти Контакти = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public Склади_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипиСкладів_List())
                ТипСкладу.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ТипСкладу.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_List())
                НалаштуванняАдресногоЗберігання.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            НалаштуванняАдресногоЗберігання.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // ТипСкладу
            CreateField(vBox, "ТипСкладу:", ТипСкладу);
                
            // Відповідальний
            CreateField(vBox, null, Відповідальний);
                
            // ВидЦін
            CreateField(vBox, null, ВидЦін);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Папка
            CreateField(vBox, null, Папка);
                
            // НалаштуванняАдресногоЗберігання
            CreateField(vBox, "НалаштуванняАдресногоЗберігання:", НалаштуванняАдресногоЗберігання);
                
            // КлючовіСловаДляПошуку
            CreateField(vBox, "КлючовіСловаДляПошуку:", КлючовіСловаДляПошуку);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
            // Таблична частина "Контакти" 
            CreateTablePart(vBox, "Контакти:", Контакти);
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Назва.SetText(Елемент.Назва);
                        Код.SetText(Елемент.Код);
                        ТипСкладу.ActiveId = Елемент.ТипСкладу.ToString();
                Відповідальний.Pointer = Елемент.Відповідальний;
                ВидЦін.Pointer = Елемент.ВидЦін;
                Підрозділ.Pointer = Елемент.Підрозділ;
                Папка.Pointer = Елемент.Папка;
                НалаштуванняАдресногоЗберігання.ActiveId = Елемент.НалаштуванняАдресногоЗберігання.ToString();
                КлючовіСловаДляПошуку.SetText(Елемент.КлючовіСловаДляПошуку);
                        
            // Таблична частина "Контакти"
            Контакти.ЕлементВласник = Елемент;
            await Контакти.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Код = Код.GetText();
                        Елемент.ТипСкладу = ПсевдонімиПерелічення.ТипиСкладів_FindByName(ТипСкладу.ActiveId);
                Елемент.Відповідальний = Відповідальний.Pointer;
                Елемент.ВидЦін = ВидЦін.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Папка = Папка.Pointer;
                Елемент.НалаштуванняАдресногоЗберігання = ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_FindByName(НалаштуванняАдресногоЗберігання.ActiveId);
                Елемент.КлючовіСловаДляПошуку = КлючовіСловаДляПошуку.GetText();
                        
    }

    #endregion

    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await Контакти.SaveRecords(); // Таблична частина "Контакти"
                
                isSaved = true;
            }
        }
        catch 
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    