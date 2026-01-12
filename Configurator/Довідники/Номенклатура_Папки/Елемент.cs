
/*
        Номенклатура_Папки_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Номенклатура_Папки_Елемент : DirectoryFormElement
{
    public Номенклатура_Папки_Objest Елемент { get; init; } = new Номенклатура_Папки_Objest();

    public Номенклатура_Папки_Pointer РодичДляНового { get; set; } = new Номенклатура_Папки_Pointer();

    #region Fields
    Entry Назва = new() { WidthRequest = 500 };
    Entry Код = new() { WidthRequest = 500 };
    Номенклатура_Папки_PointerControl Родич = new() { Caption = "Папка", WidthPresentation = 500 };

    #endregion

    #region TabularParts

    #endregion

    public Номенклатура_Папки_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

    }

    protected override void CreateStart(Box vBox)
    {

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Код
        CreateField(vBox, "Код:", Код);

        // Родич
        CreateField(vBox, null, Родич);

    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {

        if (IsNew)
            Елемент.Родич = РодичДляНового;
        else
            Родич.OpenFolder = Елемент.UnigueID;
        Назва.SetText(Елемент.Назва);
        Код.SetText(Елемент.Код);
        Родич.Pointer = Елемент.Родич;

        await ValueTask.FromResult(true);
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
        Елемент.Код = Код.GetText();
        Елемент.Родич = Родич.Pointer;

    }

    #endregion

    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {

                isSaved = true;
            }
        }
        catch 
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
