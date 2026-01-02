/*

1. Очистка помічених на видалення
2. Масове перепроведення документів

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

class PageService : InterfaceGtk4.PageService
{
    public PageService() : base(Config.Kernel, Config.NamespaceProgram, Config.NamespaceCodeGeneration, Program.BasicForm?.NotebookFunc) { }

    protected override CompositePointerControl CreateCompositeControl(string caption, UuidAndText uuidAndText) =>
        new() { Caption = caption, Pointer = uuidAndText, ClearSensetive = false, TypeSelectSensetive = false };

    protected override async ValueTask BeforeSetValue()
    {
        await ФункціїНалаштуванняКористувача.ОтриматиПеріодДляЖурналу(KeyForSettings, Period);
    }

    protected override void PeriodChanged()
    {
        ФункціїНалаштуванняКористувача.ЗаписатиПеріодДляЖурналу(KeyForSettings, Period.Period.ToString(), Period.DateStart, Period.DateStop);
    }
}