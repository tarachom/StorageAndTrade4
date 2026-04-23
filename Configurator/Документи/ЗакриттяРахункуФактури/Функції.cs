

/*
        ЗакриттяРахункуФактури_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

namespace StorageAndTrade;

static class ЗакриттяРахункуФактури_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(ЗакриттяРахункуФактури_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null,
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        ЗакриттяРахункуФактури_Елемент page = ЗакриттяРахункуФактури_Елемент.New();
        page.CallBack_LoadRecords = сallBack_LoadRecords;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        if (IsNew)
            await page.Елемент.New();
        else if (uniqueID == null || !await page.Елемент.Read(uniqueID))
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return;
        }

        Program.BasicForm?.NotebookFunc.CreatePage(page.Caption, page);
        await page.SetValue();
    }

    public static async ValueTask OpenPageList(UniqueID? uniqueID = null, Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        ЗакриттяРахункуФактури_Список page = ЗакриттяРахункуФактури_Список.New();
        page.DocumentPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        Program.BasicForm?.NotebookFunc.CreatePage(ЗакриттяРахункуФактури_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UniqueID uniqueID)
    {
        ЗакриттяРахункуФактури_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UniqueID?> Copy(UniqueID uniqueID)
    {
        ЗакриттяРахункуФактури_Objest Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            ЗакриттяРахункуФактури_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
                await Новий.Товари_TablePart.Save(false); // Таблична частина "Товари"
            
            return Новий.UniqueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    