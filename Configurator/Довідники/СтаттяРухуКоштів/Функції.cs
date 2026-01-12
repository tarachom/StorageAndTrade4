
/*
        СтаттяРухуКоштів_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class СтаттяРухуКоштів_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Код
            new Where(СтаттяРухуКоштів_Const.Код, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
            //Назва
            new Where(Comparison.OR, СтаттяРухуКоштів_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UnigueID? unigueID = null, 
        Action<UnigueID?>? сallBack_LoadRecords = null, 
        Action<UnigueID>? сallBack_OnSelectPointer = null)
    {
        СтаттяРухуКоштів_Елемент page = new()
        {
            CallBack_LoadRecords = сallBack_LoadRecords,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };

        if (IsNew)
        {
            await page.Елемент.New();
            
        }
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
        СтаттяРухуКоштів_Список page = new()
        {
            DirectoryPointerItem = unigueID,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };

        Program.BasicForm?.NotebookFunc.CreatePage(СтаттяРухуКоштів_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UnigueID unigueID)
    {
        СтаттяРухуКоштів_Pointer Вказівник = new(unigueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UnigueID?> Copy(UnigueID unigueID)
    {
        СтаттяРухуКоштів_Objest Обєкт = new();
        if (await Обєкт.Read(unigueID))
        {
            СтаттяРухуКоштів_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
                await Новий.ГосподарськіОперації_TablePart.Save(false); // Таблична частина "ГосподарськіОперації"
            
            return Новий.UnigueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    