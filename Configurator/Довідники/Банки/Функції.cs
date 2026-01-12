
/*
        Банки_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class Банки_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Код
            new Where(Банки_Const.Код, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Назва
            new Where(Comparison.OR, Банки_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //КодМФО
            new Where(Comparison.OR, Банки_Const.КодМФО, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //ПовнаНазва
            new Where(Comparison.OR, Банки_Const.ПовнаНазва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //УнікальнийКодБанку
            new Where(Comparison.OR, Банки_Const.УнікальнийКодБанку, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Адреса
            new Where(Comparison.OR, Банки_Const.Адреса, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //КодНБУ
            new Where(Comparison.OR, Банки_Const.КодНБУ, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //НомерЛіцензії
            new Where(Comparison.OR, Банки_Const.НомерЛіцензії, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UnigueID? unigueID = null, 
        Action<UnigueID?>? сallBack_LoadRecords = null, 
        Action<UnigueID>? сallBack_OnSelectPointer = null)
    {
        Банки_Елемент page = new()
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
        Банки_Список page = new()
        {
            DirectoryPointerItem = unigueID,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };

        Program.BasicForm?.NotebookFunc.CreatePage(Банки_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UnigueID unigueID)
    {
        Банки_Pointer Вказівник = new(unigueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UnigueID?> Copy(UnigueID unigueID)
    {
        Банки_Objest Обєкт = new();
        if (await Обєкт.Read(unigueID))
        {
            Банки_Objest Новий = await Обєкт.Copy(true);
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
    