/*

1. Очистка помічених на видалення
2. Масове перепроведення документів

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

[GObject.Subclass<InterfaceGtk4.PageService>]
partial class PageService : InterfaceGtk4.PageService
{
    public static PageService New()
    {
        PageService page = NewWithProperties([]);
        page.Init(Config.Kernel, Config.NamespaceProgram, Config.NamespaceCodeGeneration);
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return page;
    }

    protected override CompositePointerControl CreateCompositeControl(string caption, UuidAndText uuidAndText)
    {
        CompositePointerControl control = CompositePointerControl.New();
        control.Caption = caption;
        control.Pointer = uuidAndText;
        control.ClearSensetive = false;
        control.TypeSelectSensetive = false;

        return control;
    }

    protected override async ValueTask BeforeSetValue() => await ФункціїНалаштуванняКористувача.ОтриматиПеріодДляЖурналу(KeyForSettings, Period);

    protected override void PeriodChanged() => ФункціїНалаштуванняКористувача.ЗаписатиПеріодДляЖурналу(KeyForSettings, Period.Period.ToString(), Period.DateStart, Period.DateStop);
}