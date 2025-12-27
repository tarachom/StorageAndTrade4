/*

1. Очистка помічених на видалення
2. Масове перепроведення документів

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

class PageService : InterfaceGtk4.PageService
{
    public PageService() : base(Config.Kernel, Config.NamespaceProgram, Config.NamespaceCodeGeneration) { }

    protected override CompositePointerControl CreateCompositeControl(string caption, UuidAndText uuidAndText) =>
        new() { Caption = caption, Pointer = uuidAndText, ClearSensetive = false, TypeSelectSensetive = false };

    const string КлючНалаштуванняКористувача = "PageService";

    protected override async ValueTask BeforeSetValue()
    {
        await ФункціїНалаштуванняКористувача.ОтриматиПеріодДляЖурналу(КлючНалаштуванняКористувача, Period);
    }

    protected override void PeriodChanged()
    {
        ФункціїНалаштуванняКористувача.ЗаписатиПеріодДляЖурналу(КлючНалаштуванняКористувача, Period.Period.ToString(), Period.DateStart, Period.DateStop);
    }
}