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
    protected override Widget Document_PointerControl(DocumentPointer documentPointer)
    {
        CompositePointerControl control = CompositePointerControl.New();
        control.Caption = "Документ:";
        control.Pointer = documentPointer.GetBasis();
        control.ClearSensetive = false;
        control.TypeSelectSensetive = false;
        control.WidthPresentation = 500;

        return control;
    }

    /// <summary>
    /// Заповнення
    /// </summary>
    /// <param name="documentPointer">Відбір по документу</param>
    /// <returns></returns>
    public async ValueTask Fill(DocumentPointer documentPointer)
    {
        NotebookFunc?.SpinnerOn(GetName());

        //Додавання контрола документу на форму
        AddDocument(documentPointer);

        //Доступні регістри для даного документу
        foreach (string regAccumName in Config.Kernel.Conf.Documents[documentPointer.TypeDocument].AllowRegisterAccumulation)
        {
            switch (regAccumName)
            {
                case "ТовариНаСкладах":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            ТовариНаСкладах_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Товари на складах", getForm);
                        break;
                    }
                case "ПартіїТоварів":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            ПартіїТоварів_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Партії товарів", getForm);
                        break;
                    }
                case "ЗамовленняКлієнтів":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            ЗамовленняКлієнтів_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Замовлення клієнтів", getForm);
                        break;
                    }
                case "РозрахункиЗКлієнтами":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            РозрахункиЗКлієнтами_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Розрахунки з клієнтами", getForm);
                        break;
                    }
                case "ВільніЗалишки":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            ВільніЗалишки_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Вільні залишки", getForm);
                        break;
                    }
                case "ЗамовленняПостачальникам":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            ЗамовленняПостачальникам_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Замовлення постачальникам", getForm);
                        break;
                    }
                case "РозрахункиЗПостачальниками":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            РозрахункиЗПостачальниками_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Розрахунки з постачальниками", getForm);
                        break;
                    }
                case "РухКоштів":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            РухКоштів_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Рух коштів", getForm);
                        break;
                    }
                case "РухКоштівККМ":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            РухКоштівККМ_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Рух коштів ККМ", getForm);
                        break;
                    }
                case "Закупівлі":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            Закупівлі_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Закупівлі", getForm);
                        break;
                    }
                case "Продажі":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            Продажі_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();
                            return page;
                        }

                        await AddForm("Продажі", getForm);
                        break;
                    }
                case "ТовариВКомірках":
                    {
                        async ValueTask<Widget> getForm(bool small = true)
                        {
                            ТовариВКомірках_СписокМіні page = new() { WhereList = [new("owner", Comparison.EQ, documentPointer.UniqueID.UGuid)] };
                            if (small) page.SetHeight(300);
                            await page.SetValue();

                            return page;
                        }

                        await AddForm("Товари в комірках", getForm);
                        break;
                    }
            }
        }

        NotebookFunc?.SpinnerOff(GetName());
    }
}