
/*
        Склади_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

static class Склади_Функції
{
    public static List<Where> Відбори(string searchText)
    {
        return
        [
            
            //Назва
            new Where(Склади_Const.Назва, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //Код
            new Where(Comparison.OR, Склади_Const.Код, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
            //КлючовіСловаДляПошуку
            new Where(Comparison.OR, Склади_Const.КлючовіСловаДляПошуку, Comparison.LIKE, searchText) { FuncToField = "LOWER" },
                    
        ];
    }

    public static async ValueTask OpenPageElement(bool IsNew, UniqueID? uniqueID = null, 
        Action<UniqueID?>? сallBack_LoadRecords = null, 
        Action<UniqueID>? сallBack_OnSelectPointer = null)
    {
        Склади_Елемент page = new()
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
        Склади_Список page = new()
        {
            OpenSelect = openSelect,
            OpenFolder = openFolder,
            DirectoryPointerItem = uniqueID,
            CallBack_OnSelectPointer = сallBack_OnSelectPointer
        };
        
        Program.BasicForm?.NotebookFunc.CreatePage(Склади_Const.FULLNAME, page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UniqueID uniqueID)
    {
        Склади_Pointer Вказівник = new(uniqueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UniqueID?> Copy(UniqueID uniqueID)
    {
        Склади_Objest Обєкт = new();
        if (await Обєкт.Read(uniqueID))
        {
            Склади_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();
            
                await Новий.Контакти_TablePart.Save(false); // Таблична частина "Контакти"
            
            return Новий.UniqueID;
        }
        else
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return null;
        }
    }
}
    