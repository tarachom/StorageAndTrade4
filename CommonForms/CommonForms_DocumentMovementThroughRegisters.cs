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
using StorageAndTrade.РегістриНакопичення;

namespace StorageAndTrade;

/// <summary>
/// Рух документу по регістрах
/// </summary>
class CommonForms_DocumentMovementThroughRegisters : InterfaceGtk4.CommonForms_DocumentMovementThroughRegisters
{
    public CommonForms_DocumentMovementThroughRegisters() : base(Program.BasicForm?.NotebookFunc) { }

    public static async void Create(DocumentPointer documentPointer)
    {
        CommonForms_DocumentMovementThroughRegisters page = new();
        Program.BasicForm?.NotebookFunc.CreatePage("Проводки", () => page);
        await page.Fill(documentPointer);
    }

    /// <summary>
    /// Контрол який відображає документ для якого виводяться рухи по регістрах
    /// </summary>
    /// <param name="documentPointer">Документ вказівник</param>
    /// <returns>Widget</returns>
    protected override Widget Document_PointerControl(DocumentPointer documentPointer) =>
        new CompositePointerControl { Pointer = documentPointer.GetBasis(), Caption = "Документ:", TypeSelectSensetive = false, ClearSensetive = false, WidthPresentation = 500 };

    public async ValueTask Fill(DocumentPointer documentPointer)
    {
        AddDocumentToForm(documentPointer);

        foreach (string regAccumName in Config.Kernel.Conf.Documents[documentPointer.TypeDocument].AllowRegisterAccumulation)
        {
            switch (regAccumName)
            {
                case "ТовариНаСкладах":
                    {
                        ТовариНаСкладах_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Товари на складах", page);
                        break;
                    }
                case "ПартіїТоварів":
                    {
                        ПартіїТоварів_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Партії товарів", page);
                        break;
                    }
                case "ЗамовленняКлієнтів":
                    {
                        ЗамовленняКлієнтів_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Замовлення клієнтів", page);
                        break;
                    }
                case "РозрахункиЗКлієнтами":
                    {
                        РозрахункиЗКлієнтами_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Розрахунки з клієнтами", page);
                        break;
                    }
                case "ВільніЗалишки":
                    {
                        ВільніЗалишки_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Вільні залишки", page);
                        break;
                    }
                case "ЗамовленняПостачальникам":
                    {
                        ЗамовленняПостачальникам_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Замовлення постачальникам", page);
                        break;
                    }
                case "РозрахункиЗПостачальниками":
                    {
                        РозрахункиЗПостачальниками_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Розрахунки з постачальниками", page);
                        break;
                    }
                case "РухКоштів":
                    {
                        РухКоштів_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Рух коштів", page);
                        break;
                    }
                case "РухКоштівККМ":
                    {
                        РухКоштівККМ_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Рух коштів ККМ", page);
                        break;
                    }
                case "Закупівлі":
                    {
                        Закупівлі_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Закупівлі", page);
                        break;
                    }
                case "Продажі":
                    {
                        Продажі_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Продажі", page);
                        break;
                    }
                case "ТовариВКомірках":
                    {
                        ТовариВКомірках_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UnigueID.UGuid)] };
                        page.SetHeight(300);
                        await page.SetValue();

                        AddBlockToForm("Товари в комірках", page);
                        break;
                    }
            }
        }
    }
}