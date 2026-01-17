/*
Copyright (C) 2019-2026 TARAKHOMYN YURIY IVANOVYCH
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

/*

Спільна форма - Рух документу по регістрах

*/

using Gtk;
using AccountingSoftware;
using GeneratedCode;

using ТабличніСписки = GeneratedCode.РегістриНакопичення.ТабличніСписки;

namespace StorageAndTrade;

/// <summary>
/// Рух документу по регістрах
/// </summary>
class CommonForms_DocumentMovementThroughRegisters : InterfaceGtk4.CommonForms_DocumentMovementThroughRegisters
{
    public CommonForms_DocumentMovementThroughRegisters() : base(Program.BasicForm?.NotebookFunc) { }

    /// <summary>
    /// Контрол який відображає документ для якого виводяться рухи по регістрах
    /// </summary>
    /// <param name="documentPointer">Документ вказівник</param>
    /// <returns>Widget</returns>
    protected override Widget Document_PointerControl(DocumentPointer documentPointer) =>
        new CompositePointerControl { Pointer = documentPointer.GetBasis(), Caption = "Документ:", TypeSelectSensetive = false, ClearSensetive = false };

    public async ValueTask Заповнити(DocumentPointer documentPointer)
        {
            AddDocumentToForm(documentPointer);

            foreach (string regAccumName in Config.Kernel.Conf.Documents[documentPointer.TypeDocument].AllowRegisterAccumulation)
            {
                /*switch (regAccumName)
                {
                    case "ТовариНаСкладах":
                        {
                            ДодатиБлокНаФорму("Товари на складах", treeView);

                            ТабличніСписки.ТовариНаСкладах_Записи.AddColumn();
                            ТабличніСписки.ТовариНаСкладах_Записи.ДодатиВідбірПоДокументу(treeView, ДокументВказівник.UnigueID.UGuid);
                            await ТабличніСписки.ТовариНаСкладах_Записи.LoadRecords(treeView, null, false, false);

                            break;
                        }
                    case "ПартіїТоварів":
                        {
                            ДодатиБлокНаФорму("Партії товарів", treeView);


                            break;
                        }
                    case "ЗамовленняКлієнтів":
                        {
                            ДодатиБлокНаФорму("Замовлення клієнтів", treeView);


                            break;
                        }
                    case "РозрахункиЗКлієнтами":
                        {
                            ДодатиБлокНаФорму("Розрахунки з клієнтами", treeView);


                            break;
                        }
                    case "ВільніЗалишки":
                        {
                            ДодатиБлокНаФорму("Вільні залишки", treeView);


                            break;
                        }
                    case "ЗамовленняПостачальникам":
                        {
                            ДодатиБлокНаФорму("Замовлення постачальникам", treeView);


                            break;
                        }
                    case "РозрахункиЗПостачальниками":
                        {
                            ДодатиБлокНаФорму("Розрахунки з постачальниками", treeView);


                            break;
                        }
                    case "РухКоштів":
                        {
                            ДодатиБлокНаФорму("Рух коштів", treeView);


                            break;
                        }
                    case "РухКоштівККМ":
                        {
                            ДодатиБлокНаФорму("Рух коштів ККМ", treeView);


                            break;
                        }
                    case "Закупівлі":
                        {
                            ДодатиБлокНаФорму("Закупівлі", treeView);


                            break;
                        }
                    case "Продажі":
                        {
                            ДодатиБлокНаФорму("Продажі", treeView);


                            break;
                        }
                    case "ТовариВКомірках":
                        {
                            ДодатиБлокНаФорму("Товари в комірках", treeView);


                            break;
                        }
                }*/
            }
        }
}