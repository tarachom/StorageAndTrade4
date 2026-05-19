
/*
    
*/

using Gtk;

namespace StorageAndTrade;

class ФункціїДляДіалогуВиборуФайлів
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="filters"></param>
    /// <param name="callBackSelect"></param>
    /// <returns></returns>
    public static async ValueTask ВибратиФайл(FileFilter[] filters, Func<string?, ValueTask> callBackSelect)
    {
        if (Functions.CheckVersion(4, 10, 0) != null)
        {
            //
            //Версії нижче 4.10
            //

            FileChooserNative fileChooser = FileChooserNative.New("Виберіть файл", Program.BasicForm, FileChooserAction.Open, "Відкрити", "Скасувати");

            foreach (var filter in filters)
                fileChooser.AddFilter(filter);

            fileChooser.OnResponse += async (_, e) =>
            {
                string? path = null;
                if (e.ResponseId == (int)ResponseType.Accept)
                {
                    Gio.File? file = fileChooser.GetFile();
                    path = file?.GetPath();
                }
                await callBackSelect.Invoke(path);

                fileChooser.Dispose();
            };

            fileChooser.Show();
        }
        else
        {
            //
            //Версії 4.10 або більше
            //

            FileDialog dialog = FileDialog.New();
            dialog.Title = "Виберіть файл";

            Gio.ListStore store = Gio.ListStore.New(FileFilter.GetGType());

            foreach (var filter in filters)
                store.Append(filter);

            dialog.Filters = store;

            try
            {
                Gio.File? file = await dialog.OpenAsync(Program.BasicForm);
                await callBackSelect.Invoke(file?.GetPath());
            }
            catch
            {
                await callBackSelect.Invoke(null);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filters"></param>
    /// <param name="callBackSelect"></param>
    /// <returns></returns>
    public static async ValueTask ВибратиФайли(FileFilter[] filters, Func<string[]?, ValueTask> callBackSelect)
    {
        if (Functions.CheckVersion(4, 10, 0) != null)
        {
            //
            //Версії нижче 4.10
            //

            FileChooserNative fileChooser = FileChooserNative.New("Виберіть файли", Program.BasicForm, FileChooserAction.Open, "Відкрити", "Скасувати");
            fileChooser.SelectMultiple = true;

            foreach (var filter in filters)
                fileChooser.AddFilter(filter);

            fileChooser.OnResponse += async (_, e) =>
            {
                if (e.ResponseId == (int)ResponseType.Accept)
                {
                    Gio.ListModel filesList = fileChooser.GetFiles();

                    List<string> list = [];
                    for (uint i = 0; i < filesList.GetNItems(); i++)
                    {
                        Gio.File? file = (Gio.File?)filesList.GetObject(i);
                        string? path = file?.GetPath();

                        if (path != null) list.Add(path);
                    }

                    await callBackSelect.Invoke([.. list]);
                }
                else
                    await callBackSelect.Invoke(null);

                fileChooser.Dispose();
            };
            fileChooser.Show();
        }
        else
        {
            //
            //Версії 4.10 або більше
            //

            FileDialog dialog = FileDialog.New();
            dialog.Title = "Виберіть файли";

            Gio.ListStore store = Gio.ListStore.New(FileFilter.GetGType());

            foreach (var filter in filters)
                store.Append(filter);

            dialog.Filters = store;

            Gio.ListModel? files = await dialog.OpenMultipleAsync(Program.BasicForm);
            if (files != null)
            {
                List<string> list = [];
                for (uint i = 0; i < files.GetNItems(); i++)
                {
                    Gio.File? file = (Gio.File?)files.GetObject(i);
                    string? path = file?.GetPath();

                    if (path != null) list.Add(path);
                }

                await callBackSelect.Invoke([.. list]);
            }
            else
                await callBackSelect.Invoke(null);
        }
    }
}