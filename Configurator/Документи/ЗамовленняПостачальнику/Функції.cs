

/*
        ЗамовленняПостачальнику_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

namespace StorageAndTrade;

static class ЗамовленняПостачальнику_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(ЗамовленняПостачальнику_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Коментар
            new Where(Comparison.OR, ЗамовленняПостачальнику_Const.Коментар, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //КлючовіСловаДляПошуку
            new Where(Comparison.OR, ЗамовленняПостачальнику_Const.КлючовіСловаДляПошуку, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null,
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        ЗамовленняПостачальнику_Елемент page = ЗамовленняПостачальнику_Елемент.New();
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
        ЗамовленняПостачальнику_Список page = ЗамовленняПостачальнику_Список.New();
        page.DocumentPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        Program.BasicForm?.NotebookFunc.CreatePage(ЗамовленняПостачальнику_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UniqueID uniqueID)
    {
        ЗамовленняПостачальнику_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UniqueID?> Copy(UniqueID uniqueID)
    {
        ЗамовленняПостачальнику_Objest Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            ЗамовленняПостачальнику_Objest Новий = await Обєкт.Copy(true);
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
    