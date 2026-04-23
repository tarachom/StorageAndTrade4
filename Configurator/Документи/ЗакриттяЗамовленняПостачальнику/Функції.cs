

/*
        ЗакриттяЗамовленняПостачальнику_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

namespace StorageAndTrade;

static class ЗакриттяЗамовленняПостачальнику_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(ЗакриттяЗамовленняПостачальнику_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null,
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        ЗакриттяЗамовленняПостачальнику_Елемент page = ЗакриттяЗамовленняПостачальнику_Елемент.New();
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
        ЗакриттяЗамовленняПостачальнику_Список page = ЗакриттяЗамовленняПостачальнику_Список.New();
        page.DocumentPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        Program.BasicForm?.NotebookFunc.CreatePage(ЗакриттяЗамовленняПостачальнику_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UniqueID uniqueID)
    {
        ЗакриттяЗамовленняПостачальнику_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UniqueID?> Copy(UniqueID uniqueID)
    {
        ЗакриттяЗамовленняПостачальнику_Objest Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            ЗакриттяЗамовленняПостачальнику_Objest Новий = await Обєкт.Copy(true);
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
    