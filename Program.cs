/*
Copyright (C) 2019-2025 TARAKHOMYN YURIY IVANOVYCH
All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

/*
Автор:    Тарахомин Юрій Іванович
Адреса:   Україна, м. Львів
Сайт:     accounting.org.ua
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

class Program
{
    public static readonly Application BasicApp = Application.New("ua.org.accounting.storage_and_trade", Gio.ApplicationFlags.FlagsNone);

    /// <summary>
    /// Основна форма
    /// </summary>
    public static FormStorageAndTrade? BasicForm { get; set; }

    /// <summary>
    /// Авторизований користувач
    /// </summary>
    public static Користувачі_Pointer Користувач { get; set; } = new Користувачі_Pointer();

    static void Main()
    {
        //Підключення бібліотек
        FunctionForNativeMethods.SetMsysDirectory(@"C:\msys64\ucrt64\bin");

        BasicApp.OnActivate += (app, _) =>
        {
            var window = FormConfigurationSelection.New();
            window.Show();
        };

        BasicApp.OnShutdown += (app, args) => { };

        //Підключення стилів та тем
        FunctionForStyle.LoadDefault();

        BasicApp.RunWithSynchronizationContext(null);
    }
}