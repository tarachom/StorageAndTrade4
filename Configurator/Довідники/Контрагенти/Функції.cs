
/*
        Контрагенти_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class Контрагенти_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(Контрагенти_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Код
            new Where(Comparison.OR, Контрагенти_Const.Код, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //НазваПовна
            new Where(Comparison.OR, Контрагенти_Const.НазваПовна, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Опис
            new Where(Comparison.OR, Контрагенти_Const.Опис, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UnigueID? unigueID = null, 
        Action<UnigueID?>? сallBack_LoadRecords = null, 
        Action<UnigueID>? сallBack_OnSelectPointer = null)
    {
        Контрагенти_Елемент page = new()
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
        Контрагенти_Список page = new()
        {
            DirectoryPointerItem = unigueID,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };

        Program.BasicForm?.NotebookFunc.CreatePage(Контрагенти_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UnigueID unigueID)
    {
        Контрагенти_Pointer Вказівник = new(unigueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UnigueID?> Copy(UnigueID unigueID)
    {
        Контрагенти_Objest Обєкт = new();
        if (await Обєкт.Read(unigueID))
        {
            Контрагенти_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
                await Новий.Контакти_TablePart.Save(false); // Таблична частина "Контакти"
            
                await Новий.Файли_TablePart.Save(false); // Таблична частина "Файли"
            
            return Новий.UnigueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    