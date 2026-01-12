
/*
        ТипорозміриКомірок_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class ТипорозміриКомірок_Елемент : DirectoryFormElement
{
    public ТипорозміриКомірок_Objest Елемент { get; init; } = new ТипорозміриКомірок_Objest();
    
    #region Fields
    Entry Назва = new() { WidthRequest = 250 };
                    Entry Висота = new() { WidthRequest = 100 };
                    Entry Ширина = new() { WidthRequest = 100 };
                    Entry Глибина = new() { WidthRequest = 100 };
                    Entry Обєм = new() { WidthRequest = 100 };
                    Entry Вантажопідйомність = new() { WidthRequest = 100 };
                    
    #endregion

    #region TabularParts
    
    #endregion

    public ТипорозміриКомірок_Елемент() : base(Program.BasicForm?.NotebookFunc)
    { 
        Element = Елемент;
        
    }

    protected override void CreateStart(Box vBox)
    {
        
            // Назва
            CreateField(vBox, "Назва:", Назва);
                        
            // Висота
            CreateField(vBox, "Висота:", Висота);
                        
            // Ширина
            CreateField(vBox, "Ширина:", Ширина);
                        
            // Глибина
            CreateField(vBox, "Глибина:", Глибина);
                        
            // Обєм
            CreateField(vBox, "Обєм:", Обєм);
                        
            // Вантажопідйомність
            CreateField(vBox, "Вантажопідйомність:", Вантажопідйомність);
                        
    }

    protected override void CreateEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Назва.SetText(Елемент.Назва);
                        Висота.SetText(Елемент.Висота);
                        Ширина.SetText(Елемент.Ширина);
                        Глибина.SetText(Елемент.Глибина);
                        Обєм.SetText(Елемент.Обєм);
                        Вантажопідйомність.SetText(Елемент.Вантажопідйомність);
                        
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
                        Елемент.Висота = Висота.GetText();
                        Елемент.Ширина = Ширина.GetText();
                        Елемент.Глибина = Глибина.GetText();
                        Елемент.Обєм = Обєм.GetText();
                        Елемент.Вантажопідйомність = Вантажопідйомність.GetText();
                        
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
    