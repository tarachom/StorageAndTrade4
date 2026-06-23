
/*
        Банки_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class Банки_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Код
            new Where(Банки_Const.Код, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Назва
            new Where(Comparison.OR, Банки_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //КодМФО
            new Where(Comparison.OR, Банки_Const.КодМФО, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //ПовнаНазва
            new Where(Comparison.OR, Банки_Const.ПовнаНазва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //УнікальнийКодБанку
            new Where(Comparison.OR, Банки_Const.УнікальнийКодБанку, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Адреса
            new Where(Comparison.OR, Банки_Const.Адреса, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //КодНБУ
            new Where(Comparison.OR, Банки_Const.КодНБУ, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //НомерЛіцензії
            new Where(Comparison.OR, Банки_Const.НомерЛіцензії, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async Task OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null, 
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        Банки_Елемент page = Банки_Елемент.New();
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
        Банки_Список page = Банки_Список.New();
        page.AllowedContentSelection  = allowedContentSelection;
        page.OpenFolder = openFolder;
        page.DirectoryPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        
        Program.BasicForm?.NotebookFunc.CreatePage(Банки_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async Task SetDeletionLabel(UniqueID uniqueID)
    {
        Банки_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async Task<UniqueID?> Copy(UniqueID uniqueID)
    {
        Банки_Object Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            Банки_Object Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
            return Новий.UniqueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    