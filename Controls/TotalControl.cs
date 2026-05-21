
/*

TotalControl - контрол для виводу загальних підсумків в таб частинах документів

*/

using Gtk;

[GObject.Subclass<Box>]
public partial class TotalControl : Box
{
    event EventHandler<string>? OnChanged;

    Label total = Label.New(null);

    partial void Initialize()
    {
        SetOrientation(Orientation.Horizontal);

        Label caption = Label.New("<b>Підсумки:</b> ");
        caption.UseMarkup = true;

        Append(caption);

        total.UseMarkup = true;
        Append(total);
    }

    /// <summary>
    /// Функція обчислення
    /// </summary>
    public Func<string>? QuantifyFunc { get; set; } = null;

    /// <summary>
    /// Перерахувати
    /// </summary>
    public void Recount() => OnChanged?.Invoke(null, QuantifyFunc?.Invoke() ?? "");

    public static TotalControl New()
    {
        TotalControl control = NewWithProperties([]);
        control.OnChanged += (_, text) => control.total.SetMarkup(text);

        return control;
    }
}