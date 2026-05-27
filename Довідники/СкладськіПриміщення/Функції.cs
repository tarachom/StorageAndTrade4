
/*
        СкладськіПриміщення_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class СкладськіПриміщення_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(СкладськіПриміщення_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async Task OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null, 
        Action<UniqueID>? сallBack_OnSelectPointer = null,
            Склади_Pointer? Власник = null)
    {
        СкладськіПриміщення_Елемент page = СкладськіПриміщення_Елемент.New();
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
            Склади_Pointer? Власник = null)
    {
        СкладськіПриміщення_Список page = СкладськіПриміщення_Список.New();
        page.AllowedContentSelection  = allowedContentSelection;
        page.OpenFolder = openFolder;
        page.DirectoryPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        
            if (Власник != null) page.Власник.Pointer = Власник;
        
        Program.BasicForm?.NotebookFunc.CreatePage(СкладськіПриміщення_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async Task SetDeletionLabel(UniqueID uniqueID)
    {
        СкладськіПриміщення_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async Task<UniqueID?> Copy(UniqueID uniqueID)
    {
        СкладськіПриміщення_Objest Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            СкладськіПриміщення_Objest Новий = await Обєкт.Copy(true);
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
    