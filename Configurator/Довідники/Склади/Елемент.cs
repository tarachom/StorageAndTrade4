
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
    Entry Код = new() { WidthRequest = 100 };
                    Entry Назва = new() { WidthRequest = 500 };
                    Склади_Папки_PointerControl Папка = new() { Caption = "Папка", WidthPresentation = 500 };
            ComboBoxText ТипСкладу = new ComboBoxText();
            ФізичніОсоби_PointerControl Відповідальний = new() { Caption = "Відповідальний", WidthPresentation = 500 };
            ВидиЦін_PointerControl ВидЦін = new() { Caption = "Вид цін", WidthPresentation = 500 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 500 };
            ComboBoxText НалаштуванняАдресногоЗберігання = new ComboBoxText();
            
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
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Папка
            CreateField(vBox, null, Папка);
                
            // ТипСкладу
            CreateField(vBox, "Тип складу:", ТипСкладу);
                
            // Відповідальний
            CreateField(vBox, null, Відповідальний);
                
            // ВидЦін
            CreateField(vBox, null, ВидЦін);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // НалаштуванняАдресногоЗберігання
            CreateField(vBox, "Адресне зберігання:", НалаштуванняАдресногоЗберігання);
                
    }

    protected override void CreateEnd(Box vBox)
    {
        
            // Таблична частина "Контакти" 
            CreateTablePart(vBox, "Контакти:", Контакти);
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        Папка.Pointer = Елемент.Папка;
                ТипСкладу.ActiveId = Елемент.ТипСкладу.ToString();
                Відповідальний.Pointer = Елемент.Відповідальний;
                ВидЦін.Pointer = Елемент.ВидЦін;
                Підрозділ.Pointer = Елемент.Підрозділ;
                НалаштуванняАдресногоЗберігання.ActiveId = Елемент.НалаштуванняАдресногоЗберігання.ToString();
                
            // Таблична частина "Контакти"
            Контакти.ЕлементВласник = Елемент;
            await Контакти.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.Папка = Папка.Pointer;
                Елемент.ТипСкладу = ПсевдонімиПерелічення.ТипиСкладів_FindByName(ТипСкладу.ActiveId);
                Елемент.Відповідальний = Відповідальний.Pointer;
                Елемент.ВидЦін = ВидЦін.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.НалаштуванняАдресногоЗберігання = ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_FindByName(НалаштуванняАдресногоЗберігання.ActiveId);
                
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
        catch (Exception ex)
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    