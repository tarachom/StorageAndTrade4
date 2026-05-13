/*

CompositePointerControl - контрол тип якого оприділяється в процесі
Використовується для Довідників та Документів
В базі даних цей тип представлений композитним типом UuidAndText

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

/// <summary>
/// Переоприділення композитного контрола вибору
/// </summary>
[GObject.Subclass<InterfaceGtk4.CompositePointerControlTablePartCell>]
partial class CompositePointerControlTablePartCell : InterfaceGtk4.CompositePointerControlTablePartCell
{
    /// <summary>
    /// Новий
    /// </summary>
    /// <returns>Новий контрол</returns>
    public static CompositePointerControlTablePartCell New()
    {
        CompositePointerControlTablePartCell control = NewWithProperties([]);
        control.Kernel = Config.Kernel;
        control.NamespaceProgram = Config.NamespaceProgram;
        control.NamespaceCodeGeneration = Config.NamespaceCodeGeneration;
        control.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return control;
    }

    /// <summary>
    /// Переоприділення функції відображення
    /// </summary>
    /// <param name="uuidAndText">Дані</param>
    /// <returns>Структура</returns>
    protected override async ValueTask<CompositePointerPresentation_Record> CompositePointerPresentation(UuidAndText uuidAndText) =>
        await Functions.CompositePointerPresentation(uuidAndText);
}