/*

Стартова сторінка

*/

using Gtk;
using InterfaceGtk4;
using StorageAndTrade.AI;

namespace StorageAndTrade;

/// <summary>
/// Стартова сторінка
/// </summary>
[GObject.Subclass<Form>]
partial class PageAI : Form
{
    Box HBoxTop = New(Orientation.Horizontal, 0);
    Box HBoxBody = New(Orientation.Horizontal, 0);
    TextView Text { get; set; } = TextView.New();

    partial void Initialize()
    {
        //Кнопки
        HBoxTop.MarginBottom = 10;
        Append(HBoxTop);

        {
            Button button = Button.NewFromIconName("new");
            HBoxTop.Append(button);
        }

        HBoxBody.MarginBottom = 10;
        Append(HBoxBody);

        Text.Buffer?.Text = 
@"Додай все в папку _Нове:
Риба копчена, кг.
";

        ScrolledWindow scroll = ScrolledWindow.New();
        scroll.SetPolicy(PolicyType.Automatic, PolicyType.Automatic);
        scroll.HeightRequest = 300;
        scroll.WidthRequest = 800;
        scroll.HasFrame = true;
        scroll.SetChild(Text);
        HBoxBody.Append(scroll);

        {
            Box vBox = New(Orientation.Vertical, 0);
            vBox.Valign = Align.End;

            Box hBox = New(Orientation.Horizontal, 0);
            hBox.MarginStart = 10;

            vBox.Append(hBox);

            Button button = Button.NewWithLabel("Виконати");
            button.OnClicked += async (_, _) =>
            {
                AiWorker ai = new();
                await ai.Work(Text.Buffer?.Text);
            };
            hBox.Append(button);

            HBoxBody.Append(vBox);
        }
    }

    /// <summary>
    /// Новий об'єкт
    /// </summary>
    /// <returns>PageHome</returns>
    public static PageAI New()
    {
        PageAI page = NewWithProperties([]);
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return page;
    }

    public async Task SetValue()
    {

    }
}