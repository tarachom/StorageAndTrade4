/*

Вивід повідомлень

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

/// <summary>
/// Вивід повідомлень
/// </summary>
[GObject.Subclass<InterfaceGtk4.CommonForms_ErrorOrInfoMessageOutput>]
partial class CommonForms_ErrorOrInfoMessageOutput : InterfaceGtk4.CommonForms_ErrorOrInfoMessageOutput
{
    /// <summary>
    /// Новий
    /// </summary>
    /// <param name="width">Ширина</param>
    /// <param name="height">Висота</param>
    /// <returns>Новий контрол</returns>
    public static CommonForms_ErrorOrInfoMessageOutput New()
    {
        CommonForms_ErrorOrInfoMessageOutput view = NewWithProperties([]);
        return view;
    }

    /// <summary>
    /// Переоприділення ядра
    /// </summary>
    public override Kernel Kernel { get; init; } = Config.Kernel;

    /// <summary>
    /// Переоприділення функції для відображення назви заблокованого об'єкту
    /// </summary>
    /// <param name="uuidAndText"></param>
    /// <returns></returns>
    public override CompositePointerControl CreateCompositeControl(string caption, UuidAndText uuidAndText)
    {
        CompositePointerControl control = CompositePointerControl.New();
        control.Caption = caption;
        control.Pointer = uuidAndText;
        control.ClearSensetive = false;
        control.TypeSelectSensetive = false;

        return control;
    }
}
