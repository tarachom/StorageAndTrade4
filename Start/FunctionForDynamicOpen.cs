/*

Динамічне відкриття журналів

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode;

namespace StorageAndTrade
{
    class FunctionForDynamicOpen : InterfaceGtk4.FunctionForDynamicOpen
    {
        public FunctionForDynamicOpen() : base(Config.NameSpageProgram, Config.NameSpageCodeGeneration, Program.Form?.Notebook) { }
    }
}