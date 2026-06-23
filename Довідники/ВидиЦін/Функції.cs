
/*
        ВидиЦін_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class ВидиЦін_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Код
            new Where(ВидиЦін_Const.Код, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Назва
            new Where(Comparison.OR, ВидиЦін_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async Task OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null, 
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        ВидиЦін_Елемент page = ВидиЦін_Елемент.New();
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
        ВидиЦін_Список page = ВидиЦін_Список.New();
        page.AllowedContentSelection  = allowedContentSelection;
        page.OpenFolder = openFolder;
        page.DirectoryPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        
        Program.BasicForm?.NotebookFunc.CreatePage(ВидиЦін_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async Task SetDeletionLabel(UniqueID uniqueID)
    {
        ВидиЦін_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async Task<UniqueID?> Copy(UniqueID uniqueID)
    {
        ВидиЦін_Object Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            ВидиЦін_Object Новий = await Обєкт.Copy(true);
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
    