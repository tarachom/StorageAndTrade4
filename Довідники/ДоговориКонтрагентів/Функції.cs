
/*
        ДоговориКонтрагентів_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class ДоговориКонтрагентів_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Код
            new Where(ДоговориКонтрагентів_Const.Код, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
            //Назва
            new Where(Comparison.OR, ДоговориКонтрагентів_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
        ];
    }

    public static async Task OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null, 
        Action<UniqueID>? сallBack_OnSelectPointer = null,
            Контрагенти_Pointer? Власник = null)
    {
        ДоговориКонтрагентів_Елемент page = ДоговориКонтрагентів_Елемент.New();
        page.CallBack_LoadRecords = сallBack_LoadRecords;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        if (IsNew)
        {
            await page.Елемент.New();
            
                if (Власник != null) page.ВласникДляНового = Власник;
            
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
        Action<UniqueID>? сallBack_OnSelectPointer = null,
            Контрагенти_Pointer? Власник = null)
    {
        ДоговориКонтрагентів_Список page = ДоговориКонтрагентів_Список.New();
        page.AllowedContentSelection  = allowedContentSelection;
        page.OpenFolder = openFolder;
        page.DirectoryPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        
            if (Власник != null) page.Власник.Pointer = Власник;
        
        Program.BasicForm?.NotebookFunc.CreatePage(ДоговориКонтрагентів_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async Task SetDeletionLabel(UniqueID uniqueID)
    {
        ДоговориКонтрагентів_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async Task<UniqueID?> Copy(UniqueID uniqueID)
    {
        ДоговориКонтрагентів_Objest Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            ДоговориКонтрагентів_Objest Новий = await Обєкт.Copy(true);
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
    