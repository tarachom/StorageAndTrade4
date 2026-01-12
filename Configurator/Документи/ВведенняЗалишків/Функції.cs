

/*
        ВведенняЗалишків_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

namespace StorageAndTrade;

static class ВведенняЗалишків_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(ВведенняЗалишків_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Коментар
            new Where(Comparison.OR, ВведенняЗалишків_Const.Коментар, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //КлючовіСловаДляПошуку
            new Where(Comparison.OR, ВведенняЗалишків_Const.КлючовіСловаДляПошуку, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UnigueID? unigueID = null, 
        Action<UnigueID?>? сallBack_LoadRecords = null,
        Action<UnigueID>? сallBack_OnSelectPointer = null)
    {
        ВведенняЗалишків_Елемент page = new()
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
        ВведенняЗалишків_Список page = new()
        {
            DocumentPointerItem = unigueID,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };

        Program.BasicForm?.NotebookFunc.CreatePage(ВведенняЗалишків_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UnigueID unigueID)
    {
        ВведенняЗалишків_Pointer Вказівник = new(unigueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UnigueID?> Copy(UnigueID unigueID)
    {
        ВведенняЗалишків_Objest Обєкт = new();
        if (await Обєкт.Read(unigueID))
        {
            ВведенняЗалишків_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
                await Новий.Товари_TablePart.Save(false); // Таблична частина "Товари"
            
                await Новий.Каси_TablePart.Save(false); // Таблична частина "Каси"
            
                await Новий.БанківськіРахунки_TablePart.Save(false); // Таблична частина "БанківськіРахунки"
            
                await Новий.РозрахункиЗКонтрагентами_TablePart.Save(false); // Таблична частина "РозрахункиЗКонтрагентами"
            
            return Новий.UnigueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    