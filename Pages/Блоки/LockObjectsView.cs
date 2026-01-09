/*

Заблоковані об'єкти

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade
{
    class LockObjectsView : InterfaceGtk4.LockObjectsView
    {
        public LockObjectsView(int widthRequest = 800, int heightRequest = 500) : base(Config.Kernel, widthRequest, heightRequest) { }

        protected override async ValueTask<CompositePointerPresentation_Record> CompositePointerPresentation(UuidAndText uuidAndText)
        {
            return await Functions.CompositePointerPresentation(uuidAndText);
        }
    }
}