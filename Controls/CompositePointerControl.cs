/*

CompositePointerControl - контрол тип якого оприділяється в процесі
Використовується для Довідників та Документів
В базі даних цей тип представлений композитним типом UuidAndText

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

[GObject.Subclass<InterfaceGtk4.CompositePointerControl>]
partial class CompositePointerControl : InterfaceGtk4.CompositePointerControl
{
    public static CompositePointerControl New()
    {
        CompositePointerControl control = NewWithProperties([]);
        control.Kernel = Config.Kernel;
        control.NamespaceProgram = Config.NamespaceProgram;
        control.NamespaceCodeGeneration = Config.NamespaceCodeGeneration;
        control.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return control;
    }

    protected override async ValueTask<CompositePointerPresentation_Record> CompositePointerPresentation(UuidAndText uuidAndText) =>
        await Functions.CompositePointerPresentation(uuidAndText);
}