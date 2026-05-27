
/*
        Організації_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class Організації_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(Організації_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Код
            new Where(Comparison.OR, Організації_Const.Код, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //НазваСкорочена
            new Where(Comparison.OR, Організації_Const.НазваСкорочена, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //СвідоцтвоСеріяНомер
            new Where(Comparison.OR, Організації_Const.СвідоцтвоСеріяНомер, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //СвідоцтвоДатаВидачі
            new Where(Comparison.OR, Організації_Const.СвідоцтвоДатаВидачі, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //КлючовіСловаДляПошуку
            new Where(Comparison.OR, Організації_Const.КлючовіСловаДляПошуку, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async Task OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null, 
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        Організації_Елемент page = Організації_Елемент.New();
        page.CallBack_LoadRecords = сallBack_LoadRecords;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        if (IsNew)
        {
            await page.Елемент.New();
            
        }
        else if (uniqueID == null || !await page.Елемент.Read(uniqueID))
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return;
        }

        Program.BasicForm?.NotebookFunc.CreatePage(page.Caption, page);
        await page.SetValue();
    }

    public static async Task OpenPageList(UniqueID? uniqueID = null, ConfigurationDirectories.HierarchicalContentType? allowedContentSelection = null, UniqueID? openFolder = null,
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        Організації_Список page = Організації_Список.New();
        page.AllowedContentSelection  = allowedContentSelection;
        page.OpenFolder = openFolder;
        page.DirectoryPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        
        Program.BasicForm?.NotebookFunc.CreatePage(Організації_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async Task SetDeletionLabel(UniqueID uniqueID)
    {
        Організації_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async Task<UniqueID?> Copy(UniqueID uniqueID)
    {
        Організації_Objest Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            Організації_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
                await Новий.Контакти_TablePart.Save(false); // Таблична частина "Контакти"
            
            return Новий.UniqueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    