/*

Заблоковані об'єкти

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

class LockObjectsView(int width = 800, int height = 500) : InterfaceGtk4.LockObjectsView(Config.Kernel, width, height)
{
    protected override async ValueTask<CompositePointerPresentation_Record> CompositePointerPresentation(UuidAndText uuidAndText) =>
        await Functions.CompositePointerPresentation(uuidAndText);
}
