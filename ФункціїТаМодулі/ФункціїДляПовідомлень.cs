/*
 
Повідомлення про помилки

*/

using Gtk;
using AccountingSoftware;

using GeneratedCode;

namespace StorageAndTrade;

static class ФункціїДляПовідомлень
{
    public static async void ДодатиПовідомлення(UuidAndText? basis, string НазваОбєкту, Exception exception)
    {
        await Config.Kernel.MessageErrorAdd("Запис", basis?.Uuid, basis?.Text, НазваОбєкту, exception.Message);
        ПоказатиПовідомлення(basis?.UniqueID());
    }

    public static async void ДодатиІнформаційнеПовідомлення(UuidAndText? basis, string НазваОбєкту, string Повідомлення)
    {
        await Config.Kernel.MessageInfoAdd("Інформація", basis?.Uuid, basis?.Text, НазваОбєкту, Повідомлення);
        ПоказатиПовідомлення();
    }

    public static async void ВідкритиПовідомлення()
    {
        CommonForms_ErrorMessageOutput page = CommonForms_ErrorMessageOutput.New();
        Program.BasicForm?.NotebookFunc.CreatePage("Повідомлення", page);
        await page.LoadRecords();
    }

    public static async void ПоказатиПовідомлення(UniqueID? ВідбірПоОбєкту = null, int? limit = null)
    {
        Button? buttonMessage = Program.BasicForm?.ButtonMessage;
        if (buttonMessage != null)
        {
            CommonForms_ErrorMessageOutput page = CommonForms_ErrorMessageOutput.New();

            Popover popover = Popover.New();
            popover.SetParent(buttonMessage);
            popover.Position = PositionType.Bottom;
            popover.WidthRequest = 600;
            popover.HeightRequest = 600;

            popover.SetChild(page);
            popover.Show();

            await page.LoadRecords(ВідбірПоОбєкту, limit);
        }
    }
}