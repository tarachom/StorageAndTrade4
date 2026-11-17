/*

CompositePointerControl - контрол тип якого оприділяється в процесі
Використовується для Довідників та Документів
В базі даних цей тип представлений композитним типом UuidAndText

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

[GObject.Subclass<InterfaceGtk4.CompositePointerControl>(nameof(CompositePointerControl))]
partial class CompositePointerControl : InterfaceGtk4.CompositePointerControl
{
    public static CompositePointerControl New() => NewWithProperties([]);

    partial void Initialize()
    {
        Kernel = Config.Kernel;
        NamespaceProgram = Config.NamespaceProgram;
        NamespaceCodeGeneration = Config.NamespaceCodeGeneration;
        NotebookFunc = Program.BasicForm?.NotebookFunc;
    }

    protected override async Task<CompositePointerPresentation_Record> CompositePointerPresentation(UuidAndText uuidAndText) =>
        await Functions.CompositePointerPresentation(uuidAndText);
}