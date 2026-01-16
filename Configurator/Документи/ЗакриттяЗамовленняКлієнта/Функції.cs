

/*
        ЗакриттяЗамовленняКлієнта_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

namespace StorageAndTrade;

static class ЗакриттяЗамовленняКлієнта_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(ЗакриттяЗамовленняКлієнта_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //НомерДок
            new Where(Comparison.OR, ЗакриттяЗамовленняКлієнта_Const.НомерДок, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //ДатаДок
            new Where(Comparison.OR, ЗакриттяЗамовленняКлієнта_Const.ДатаДок, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
            //Коментар
            new Where(Comparison.OR, ЗакриттяЗамовленняКлієнта_Const.Коментар, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UnigueID? unigueID = null, 
        Action<UnigueID?>? сallBack_LoadRecords = null,
        Action<UnigueID>? сallBack_OnSelectPointer = null)
    {
        ЗакриттяЗамовленняКлієнта_Елемент page = new()
        {
            CallBack_LoadRecords = сallBack_LoadRecords,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };

        if (IsNew)
            await page.Елемент.New();
        else if (unigueID == null || !await page.Елемент.Read(unigueID))
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return;
        }

        Program.BasicForm?.NotebookFunc.CreatePage(page.Caption, page);
        await page.SetValue();
    }

    public static async ValueTask OpenPageList(UnigueID? unigueID = null, Action<UnigueID>? сallBack_OnSelectPointer = null)
    {
        ЗакриттяЗамовленняКлієнта_Список page = new()
        {
            DocumentPointerItem = unigueID,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };

        Program.BasicForm?.NotebookFunc.CreatePage(ЗакриттяЗамовленняКлієнта_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UnigueID unigueID)
    {
        ЗакриттяЗамовленняКлієнта_Pointer Вказівник = new(unigueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UnigueID?> Copy(UnigueID unigueID)
    {
        ЗакриттяЗамовленняКлієнта_Objest Обєкт = new();
        if (await Обєкт.Read(unigueID))
        {
            ЗакриттяЗамовленняКлієнта_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
                await Новий.Товари_TablePart.Save(false); // Таблична частина "Товари"
            
            return Новий.UnigueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    