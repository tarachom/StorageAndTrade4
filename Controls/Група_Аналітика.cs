/*

*/

using Gtk;

namespace StorageAndTrade;

/// <summary>
/// Група із трьох контролів типу CompositePointerControlTablePartCell
/// розміщених вертикально в стовпчик
/// </summary>
[GObject.Subclass<Box>("CompositeGroup")]
partial class Група_Аналітика : Box
{
    public static Група_Аналітика New() => NewWithProperties([]);

    partial void Initialize()
    {
        SetOrientation(Orientation.Vertical);

        Append(Аналітика1);
        Append(Аналітика2);
        Append(Аналітика3);
    }

    public CompositePointerControlTablePartCell Аналітика1 { get; } = CompositePointerControlTablePartCell.New();
    public CompositePointerControlTablePartCell Аналітика2 { get; } = CompositePointerControlTablePartCell.New();
    public CompositePointerControlTablePartCell Аналітика3 { get; } = CompositePointerControlTablePartCell.New();
}