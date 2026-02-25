
/*
        Номенклатура_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class Номенклатура_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(Номенклатура_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Код
            new Where(Comparison.OR, Номенклатура_Const.Код, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //НазваПовна
            new Where(Comparison.OR, Номенклатура_Const.НазваПовна, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Опис
            new Where(Comparison.OR, Номенклатура_Const.Опис, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Артикул
            new Where(Comparison.OR, Номенклатура_Const.Артикул, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null, 
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        Номенклатура_Елемент page = new()
        {
            CallBack_LoadRecords = сallBack_LoadRecords,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };

        if (IsNew)
        {
            await page.Елемент.New();
            
        }
        else if (uniqueID == null || !await page.Елемент.Read(uniqueID))
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return;
        }

        Program.BasicForm?.NotebookFunc.CreatePage(page.Caption, page);
        await page.SetValue();
    }

    public static async ValueTask OpenPageList(UniqueID? uniqueID = null, bool openSelect = false, UniqueID? openFolder = null,
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        Номенклатура_Список page = new()
        {
            OpenSelect = openSelect,
            OpenFolder = openFolder,
            DirectoryPointerItem = uniqueID,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };
        
        Program.BasicForm?.NotebookFunc.CreatePage(Номенклатура_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UniqueID uniqueID)
    {
        Номенклатура_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UniqueID?> Copy(UniqueID uniqueID)
    {
        Номенклатура_Objest Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            Номенклатура_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
                await Новий.Файли_TablePart.Save(false); // Таблична частина "Файли"
            
            return Новий.UniqueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    