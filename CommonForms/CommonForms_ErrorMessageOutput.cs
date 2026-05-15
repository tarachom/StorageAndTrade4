/*

Заблоковані об'єкти

*/

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

/// <summary>
/// 
/// </summary>
[GObject.Subclass<InterfaceGtk4.CommonForms_ErrorMessageOutput>]
partial class CommonForms_ErrorMessageOutput : InterfaceGtk4.CommonForms_ErrorMessageOutput
{
    /// <summary>
    /// Новий
    /// </summary>
    /// <param name="width">Ширина</param>
    /// <param name="height">Висота</param>
    /// <returns>Новий контрол</returns>
    public static CommonForms_ErrorMessageOutput New()
    {
        CommonForms_ErrorMessageOutput view = NewWithProperties([]);
        view.Init(Config.Kernel);

        return view;
    }

    /// <summary>
    /// Переоприділення функції для відображення назви заблокованого об'єкту
    /// </summary>
    /// <param name="uuidAndText"></param>
    /// <returns></returns>
    protected override CompositePointerControl CreateCompositeControl(string caption, UuidAndText uuidAndText)
    {
        CompositePointerControl control = CompositePointerControl.New();
        control.Caption = caption;
        control.Pointer = uuidAndText;
        control.ClearSensetive = false;
        control.TypeSelectSensetive = false;

        return control;
    }
}
