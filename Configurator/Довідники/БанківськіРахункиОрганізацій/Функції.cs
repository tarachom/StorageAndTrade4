
/*
        БанківськіРахункиОрганізацій_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class БанківськіРахункиОрганізацій_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Код
            new Where(БанківськіРахункиОрганізацій_Const.Код, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
            //Назва
            new Where(Comparison.OR, БанківськіРахункиОрганізацій_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "TO_CHAR", FuncToField_Param1 = "''" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UnigueID? unigueID = null, 
        Action<UnigueID?>? сallBack_LoadRecords = null, 
        Action<UnigueID>? сallBack_OnSelectPointer = null)
    {
        БанківськіРахункиОрганізацій_Елемент page = new()
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
        БанківськіРахункиОрганізацій_Список page = new()
        {
            DirectoryPointerItem = unigueID,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };

        Program.BasicForm?.NotebookFunc.CreatePage(БанківськіРахункиОрганізацій_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UnigueID unigueID)
    {
        БанківськіРахункиОрганізацій_Pointer Вказівник = new(unigueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UnigueID?> Copy(UnigueID unigueID)
    {
        БанківськіРахункиОрганізацій_Objest Обєкт = new();
        if (await Обєкт.Read(unigueID))
        {
            БанківськіРахункиОрганізацій_Objest Новий = await Обєкт.Copy(true);
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
    