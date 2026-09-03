/*
 
Повідомлення про помилки та інформаційні повідомлення

*/

using Gtk;
using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

static class ФункціїДляПовідомлень
{
    public static async void ДодатиПовідомлення(UuidAndText? basis, string НазваОбєкту, Exception exception)
    {
        await Config.Kernel.MessageErrorAdd("Помилка", basis, НазваОбєкту, exception.Message);
        ПоказатиПовідомлення(basis?.UniqueID());
    }

    public static async void ДодатиІнформаційнеПовідомлення(UuidAndText? basis, string НазваОбєкту, string Повідомлення)
    {
        await Config.Kernel.MessageInfoAdd("Інформація", basis, НазваОбєкту, Повідомлення);
        ПоказатиПовідомлення();
    }

    public static async void ДодатиПовідомленняПроФайл(UuidAndText? basis, string НазваОбєкту, string Повідомлення, string? ШляхДоФайлу = null)
    {
        string link = ШляхДоФайлу != null ? $" <a href=\"file:///{ШляхДоФайлу}\" title=\"{ШляхДоФайлу}\">{Path.GetFileName(ШляхДоФайлу)}</a>" : "";

        await Config.Kernel.MessageFileAdd("Файл", basis, НазваОбєкту, Повідомлення + link);
        ПоказатиПовідомлення();
    }

    public static async void ВідкритиПовідомлення()
    {
        CommonForms_ErrorOrInfoMessageOutput page = CommonForms_ErrorOrInfoMessageOutput.New();
        Program.BasicForm?.NotebookFunc.CreatePage("Повідомлення", page);
        await page.LoadRecords();
    }

    static Popover? Popover { get; set; } = null;

    public static async void ПоказатиПовідомлення(UniqueID? ВідбірПоОбєкту = null, int? limit = null)
    {
        Button? buttonMessage = Program.BasicForm?.ButtonMessage;
        if (buttonMessage != null)
        {
            if (Popover == null)
            {
                Popover = Popover.New();
                Popover.OnClosed += (_, _) => Popover = null;
                Popover.SetParent(buttonMessage);
                Popover.Position = PositionType.Bottom;
                Popover.WidthRequest = 600;
                Popover.HeightRequest = 600;
            }

            CommonForms_ErrorOrInfoMessageOutput page = CommonForms_ErrorOrInfoMessageOutput.New();

            Popover.SetChild(page);
            Popover.Show();

            await page.LoadRecords(ВідбірПоОбєкту, limit);
        }
    }
}