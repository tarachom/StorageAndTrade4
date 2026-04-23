

/*
        РозхіднийКасовийОрдер_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

namespace StorageAndTrade;

static class РозхіднийКасовийОрдер_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(РозхіднийКасовийОрдер_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Коментар
            new Where(Comparison.OR, РозхіднийКасовийОрдер_Const.Коментар, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //КлючовіСловаДляПошуку
            new Where(Comparison.OR, РозхіднийКасовийОрдер_Const.КлючовіСловаДляПошуку, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null,
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        РозхіднийКасовийОрдер_Елемент page = РозхіднийКасовийОрдер_Елемент.New();
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
        РозхіднийКасовийОрдер_Список page = РозхіднийКасовийОрдер_Список.New();
        page.DocumentPointerItem = uniqueID;
        page.CallBack_OnSelectPointer = сallBack_OnSelectPointer;

        Program.BasicForm?.NotebookFunc.CreatePage(РозхіднийКасовийОрдер_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UniqueID uniqueID)
    {
        РозхіднийКасовийОрдер_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UniqueID?> Copy(UniqueID uniqueID)
    {
        РозхіднийКасовийОрдер_Objest Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            РозхіднийКасовийОрдер_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
                await Новий.РозшифруванняПлатежу_TablePart.Save(false); // Таблична частина "РозшифруванняПлатежу"
            
            return Новий.UniqueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    