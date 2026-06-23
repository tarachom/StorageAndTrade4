

/*
        НарахуванняЗаробітньоїПлати_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

namespace StorageAndTrade;

static class НарахуванняЗаробітньоїПлати_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(НарахуванняЗаробітньоїПлати_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Коментар
            new Where(Comparison.OR, НарахуванняЗаробітньоїПлати_Const.Коментар, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async Task OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null,
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        НарахуванняЗаробітньоїПлати_Елемент page = НарахуванняЗаробітньоїПлати_Елемент.New();
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

    public static async Task OpenPageList(UniqueID? uniqueID = null, Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        НарахуванняЗаробітньоїПлати_Список page = НарахуванняЗаробітньоїПлати_Список.New();
        page.DocumentPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        Program.BasicForm?.NotebookFunc.CreatePage(НарахуванняЗаробітньоїПлати_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async Task SetDeletionLabel(UniqueID uniqueID)
    {
        НарахуванняЗаробітньоїПлати_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async Task<UniqueID?> Copy(UniqueID uniqueID)
    {
        НарахуванняЗаробітньоїПлати_Object Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            НарахуванняЗаробітньоїПлати_Object Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
            return Новий.UniqueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }

    public static async Task SpendTheDocument(UniqueID uniqueID, bool spendDoc)
    {
        НарахуванняЗаробітньоїПлати_Object? Обєкт = await new НарахуванняЗаробітньоїПлати_Pointer(uniqueID).GetDocumentObject(true);
        if (Обєкт == null) return;

        if (spendDoc)
        {
            if (!await Обєкт.SpendTheDocument(Обєкт.ДатаДок))
                ФункціїДляПовідомлень.ПоказатиПовідомлення(Обєкт.UniqueID);
        }
        else
            await Обєкт.ClearSpendTheDocument();
    }
}
    