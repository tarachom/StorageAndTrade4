
/*
        ХарактеристикиНоменклатури_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class ХарактеристикиНоменклатури_Елемент : DirectoryFormElement
{
    public ХарактеристикиНоменклатури_Objest Елемент { get; init; } = new();
    
    public Номенклатура_Pointer ВласникДляНового = new();
    
    #region Fields
    Entry Код = Entry.New();
                    Entry Назва = Entry.New();
                    Номенклатура_PointerControl Номенклатура = Номенклатура_PointerControl.New();
            TextView НазваПовна = TextView.New();
                    
    #endregion

    #region TabularParts
    
    #endregion

    public ХарактеристикиНоменклатури_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;

        Код.WidthRequest = 100;
                        Назва.WidthRequest = 300;
                        Номенклатура.Caption = "Номенклатура";
                    Номенклатура.WidthPresentation = 300;
                НазваПовна.WrapMode = WrapMode.Word;
                        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Код
            CreateField(vBox, "Код:", Код);
                        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Номенклатура
            CreateField(vBox, null, Номенклатура);
                
            // НазваПовна
            CreateFieldView(vBox, "Повна назва:", НазваПовна, 500, 200);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        
        if (IsNew) 
            Елемент.Номенклатура = ВласникДляНового;
        Код.SetText(Елемент.Код);
                        Назва.SetText(Елемент.Назва);
                        Номенклатура.Pointer = Елемент.Номенклатура;
                НазваПовна.Buffer?.Text = Елемент.НазваПовна;
                        
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
                        Елемент.Назва = Назва.GetText();
                        Елемент.Номенклатура = Номенклатура.Pointer;
                Елемент.НазваПовна = НазваПовна.Buffer?.Text ?? "";
                        
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
        catch (Exception ex)
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
    