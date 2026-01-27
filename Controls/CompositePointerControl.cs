/*

CompositePointerControl - контрол тип якого оприділяється в процесі
Використовується для Довідників та Документів
В базі даних цей тип представлений композитним типом UuidAndText

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

class CompositePointerControl : InterfaceGtk4.CompositePointerControl
{
    public CompositePointerControl() : base(Config.Kernel, Config.NameSpageProgram, Config.NameSpageCodeGeneration, Program.BasicForm?.NotebookFunc) { }

    protected override async ValueTask<CompositePointerPresentation_Record> CompositePointerPresentation(UuidAndText uuidAndText) =>
        await GeneratedCode.Functions.CompositePointerPresentation(uuidAndText);
}