
using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

[GObject.Subclass<InterfaceGtk4.ReportPage>()]
partial class ReportPage : InterfaceGtk4.ReportPage
{
    /// <summary>
    /// Переоприділення ядра
    /// </summary>
    public override Kernel Kernel { get; init; } = Config.Kernel;

    public static ReportPage New() => NewWithProperties([]);
}