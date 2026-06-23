
/*
        ЗбереженіЗвіти_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class ЗбереженіЗвіти_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(ЗбереженіЗвіти_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Опис
            new Where(Comparison.OR, ЗбереженіЗвіти_Const.Опис, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async Task OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null, 
        Action<UniqueID>? сallBack_OnSelectPointer = null,
            Користувачі_Pointer? Власник = null)
    {
        ЗбереженіЗвіти_Елемент page = ЗбереженіЗвіти_Елемент.New();
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
            Користувачі_Pointer? Власник = null)
    {
        ЗбереженіЗвіти_Список page = ЗбереженіЗвіти_Список.New();
        page.AllowedContentSelection  = allowedContentSelection;
        page.OpenFolder = openFolder;
        page.DirectoryPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        
            if (Власник != null) page.Власник.Pointer = Власник;
        
        Program.BasicForm?.NotebookFunc.CreatePage(ЗбереженіЗвіти_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async Task SetDeletionLabel(UniqueID uniqueID)
    {
        ЗбереженіЗвіти_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async Task<UniqueID?> Copy(UniqueID uniqueID)
    {
        ЗбереженіЗвіти_Object Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            ЗбереженіЗвіти_Object Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
                await Новий.ЗвітСторінка_TablePart.Save(false); // Таблична частина "ЗвітСторінка"
            
            return Новий.UniqueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    