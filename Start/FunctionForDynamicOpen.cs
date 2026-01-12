/*

Динамічне відкриття журналів

*/

using GeneratedCode;

namespace StorageAndTrade;

class FunctionForDynamicOpen : InterfaceGtk4.FunctionForDynamicOpen
{
    public FunctionForDynamicOpen() : base(Config.NamespaceProgram, Config.NamespaceCodeGeneration, Program.BasicForm?.NotebookFunc) { }
}
