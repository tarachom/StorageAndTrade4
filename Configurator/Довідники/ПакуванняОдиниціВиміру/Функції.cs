
/*
        ПакуванняОдиниціВиміру_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class ПакуванняОдиниціВиміру_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Код
            new Where(ПакуванняОдиниціВиміру_Const.Код, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
            //Назва
            new Where(Comparison.OR, ПакуванняОдиниціВиміру_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UnigueID? unigueID = null, 
        Action<UnigueID?>? сallBack_LoadRecords = null, 
        Action<UnigueID>? сallBack_OnSelectPointer = null)
    {
        ПакуванняОдиниціВиміру_Елемент page = new()
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
        ПакуванняОдиниціВиміру_Список page = new()
        {
            DirectoryPointerItem = unigueID,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };

        Program.BasicForm?.NotebookFunc.CreatePage(ПакуванняОдиниціВиміру_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UnigueID unigueID)
    {
        ПакуванняОдиниціВиміру_Pointer Вказівник = new(unigueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UnigueID?> Copy(UnigueID unigueID)
    {
        ПакуванняОдиниціВиміру_Objest Обєкт = new();
        if (await Обєкт.Read(unigueID))
        {
            ПакуванняОдиниціВиміру_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
            return Новий.UnigueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    