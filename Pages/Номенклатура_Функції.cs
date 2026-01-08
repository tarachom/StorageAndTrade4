
/*
        Номенклатура_Функції.cs
        Функції
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode;

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

    public static async ValueTask OpenPageElement(bool IsNew, UnigueID? unigueID = null,
        Action<UnigueID?>? сallBack_LoadRecords = null,
        Action<UnigueID>? сallBack_OnSelectPointer = null)
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
        else if (unigueID == null || !await page.Елемент.Read(unigueID))
        {
            Message.Error(Program.BasicApp, Program.BasicForm, "Не вдалось прочитати!");
            return;
        }

        Program.BasicForm?.NotebookFunc.CreatePage(page.Caption, () => page);
        await page.SetValue();
    }

    public static async ValueTask SetDeletionLabel(UnigueID unigueID)
    {
        Номенклатура_Pointer Вказівник = new(unigueID);
        bool? label = await Вказівник.GetDeletionLabel();
        if (label.HasValue) await Вказівник.SetDeletionLabel(!label.Value);
    }

    public static async ValueTask<UnigueID?> Copy(UnigueID unigueID)
    {
        Номенклатура_Objest Обєкт = new();
        if (await Обєкт.Read(unigueID))
        {
            Номенклатура_Objest Новий = await Обєкт.Copy(true);
            await Новий.Save();

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

