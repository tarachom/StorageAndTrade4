

/*
        ПереміщенняТоварівНаСкладі_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

namespace StorageAndTrade;

static class ПереміщенняТоварівНаСкладі_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(ПереміщенняТоварівНаСкладі_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Коментар
            new Where(Comparison.OR, ПереміщенняТоварівНаСкладі_Const.Коментар, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //КлючовіСловаДляПошуку
            new Where(Comparison.OR, ПереміщенняТоварівНаСкладі_Const.КлючовіСловаДляПошуку, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null,
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        ПереміщенняТоварівНаСкладі_Елемент page = ПереміщенняТоварівНаСкладі_Елемент.New();
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
        ПереміщенняТоварівНаСкладі_Список page = ПереміщенняТоварівНаСкладі_Список.New();
        page.DocumentPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        Program.BasicForm?.NotebookFunc.CreatePage(ПереміщенняТоварівНаСкладі_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UniqueID uniqueID)
    {
        ПереміщенняТоварівНаСкладі_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UniqueID?> Copy(UniqueID uniqueID)
    {
        ПереміщенняТоварівНаСкладі_Objest Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            ПереміщенняТоварівНаСкладі_Objest Новий = await Обєкт.Copy(true);
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
    