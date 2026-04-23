/*

Заблоковані об'єкти

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

/// <summary>
/// Контрол для відображення стану блокування об'єктів
/// </summary>
[GObject.Subclass<InterfaceGtk4.LockObjectsView>]
partial class LockObjectsView : InterfaceGtk4.LockObjectsView
{
    /// <summary>
    /// Новий
    /// </summary>
    /// <param name="width">Ширина</param>
    /// <param name="height">Висота</param>
    /// <returns>Новий контрол</returns>
    public static LockObjectsView New(int width = 800, int height = 500)
    {
        LockObjectsView view = NewWithProperties([]);
        view.Init(Config.Kernel, width, height);

        return view;
    }

    /// <summary>
    /// Переоприділення функції для відображення назви заблокованого об'єкту
    /// </summary>
    /// <param name="uuidAndText"></param>
    /// <returns></returns>
    protected override async ValueTask<CompositePointerPresentation_Record> CompositePointerPresentation(UuidAndText uuidAndText) =>
        await Functions.CompositePointerPresentation(uuidAndText);
}
