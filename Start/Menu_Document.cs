/*

Документи

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

class Menu_Document : Form
{
    public Menu_Document() : base(Program.BasicForm?.NotebookFunc)
    {
        //Список
        Box hBoxList = New(Orientation.Horizontal, 0);
        Append(hBoxList);

        Box vLeft = New(Orientation.Vertical, 0);
        hBoxList.Append(vLeft);

        //Продажі
        {
            CreateCaptionLink(vLeft, "Продажі", async () =>
            {
                /*Журнал_Продажі page = new Журнал_Продажі();
                NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, "Продажі", () => page);
                await page.SetValue();*/
            });

            //ЗамовленняКлієнта та ЗакриттяЗамовленняКлієнта
            {
                Box hBox = New(Orientation.Horizontal, 0);
                vLeft.Append(hBox);

                CreateLink(hBox, ЗамовленняКлієнта_Const.FULLNAME, async () =>
                {
                    ЗамовленняКлієнта_Список page = new();
                    NotebookFunc?.CreatePage(ЗамовленняКлієнта_Const.FULLNAME, page);
                    await page.SetValue();
                });

                CreateLink(hBox, "Закриття", async () =>
                {
                    ЗакриттяЗамовленняКлієнта_Список page = new();
                    NotebookFunc?.CreatePage(ЗакриттяЗамовленняКлієнта_Const.FULLNAME, page);
                    await page.SetValue();
                });
            }

            //РахунокФактура та ЗакриттяРахункуФактури
            {
                Box hBox = New(Orientation.Horizontal, 0);
                vLeft.Append(hBox);

                CreateLink(hBox, РахунокФактура_Const.FULLNAME, async () =>
                {
                    РахунокФактура_Список page = new();
                    NotebookFunc?.CreatePage(РахунокФактура_Const.FULLNAME, page);
                    await page.SetValue();
                });

                CreateLink(hBox, "Закриття", async () =>
                {
                    ЗакриттяРахункуФактури_Список page = new();
                    NotebookFunc?.CreatePage(ЗакриттяРахункуФактури_Const.FULLNAME, page);
                    await page.SetValue();
                });
            }

            CreateLink(vLeft, РеалізаціяТоварівТаПослуг_Const.FULLNAME, async () =>
            {
                РеалізаціяТоварівТаПослуг_Список page = new();
                NotebookFunc?.CreatePage(РеалізаціяТоварівТаПослуг_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vLeft, АктВиконанихРобіт_Const.FULLNAME, async () =>
            {
                АктВиконанихРобіт_Список page = new();
                NotebookFunc?.CreatePage(АктВиконанихРобіт_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vLeft, ПоверненняТоварівВідКлієнта_Const.FULLNAME, async () =>
            {
                ПоверненняТоварівВідКлієнта_Список page = new();
                NotebookFunc?.CreatePage(ПоверненняТоварівВідКлієнта_Const.FULLNAME, () => page);
                await page.SetValue();
            });
        }

        {
            CreateCaptionLink(vLeft, "Закупівлі", async () =>
            {
                /*Журнал_Закупівлі page = new Журнал_Закупівлі();
                NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, "Закупівлі", () => page);
                await page.SetValue();*/
            });

            //ЗамовленняПостачальнику та ЗакриттяЗамовленняПостачальнику
            {
                Box hBox = New(Orientation.Horizontal, 0);
                vLeft.Append(hBox);

                CreateLink(hBox, ЗамовленняПостачальнику_Const.FULLNAME, async () =>
                {
                    ЗамовленняПостачальнику_Список page = new();
                    NotebookFunc?.CreatePage(ЗамовленняПостачальнику_Const.FULLNAME, page);
                    await page.SetValue();
                });

                CreateLink(hBox, "Закриття", async () =>
                {
                    ЗакриттяЗамовленняПостачальнику_Список page = new();
                    NotebookFunc?.CreatePage(ЗакриттяЗамовленняПостачальнику_Const.FULLNAME, page);
                    await page.SetValue();
                });
            }

            CreateLink(vLeft, ПоступленняТоварівТаПослуг_Const.FULLNAME, async () =>
            {
                ПоступленняТоварівТаПослуг_Список page = new();
                NotebookFunc?.CreatePage(ПоступленняТоварівТаПослуг_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vLeft, ПоверненняТоварівПостачальнику_Const.FULLNAME, async () =>
            {
                ПоверненняТоварівПостачальнику_Список page = new();
                NotebookFunc?.CreatePage(ПоверненняТоварівПостачальнику_Const.FULLNAME, page);
                await page.SetValue();
            });
        }

        {
            CreateCaptionLink(vLeft, "Ціноутворення");

            CreateLink(vLeft, ВстановленняЦінНоменклатури_Const.FULLNAME, async () =>
            {
                ВстановленняЦінНоменклатури_Список page = new();
                NotebookFunc?.CreatePage(ВстановленняЦінНоменклатури_Const.FULLNAME, page);
                await page.SetValue();
            });
        }

        {
            CreateCaptionLink(vLeft, "Роздріб", async () =>
            {
                /*Журнал_Роздріб page = new Журнал_Роздріб();
                NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, "Роздріб", () => page);
                await page.SetValue();*/
            });

            CreateLink(vLeft, ЧекККМ_Const.FULLNAME, async () =>
            {
                ЧекККМ_Список page = new();
                NotebookFunc?.CreatePage(ЧекККМ_Const.FULLNAME, page);
                await page.SetValue();
            });
        }

        CreateSeparator(hBoxList);

        Box vRight = New(Orientation.Vertical, 0);
        hBoxList.Append(vRight);

        {
            CreateCaptionLink(vRight, "Каса", async () =>
            {
                /*Журнал_Каса page = new Журнал_Каса();
                NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, "Каса", () => page);
                await page.SetValue();*/
            });

            CreateLink(vRight, ПрихіднийКасовийОрдер_Const.FULLNAME, async () =>
            {
                ПрихіднийКасовийОрдер_Список page = new();
                NotebookFunc?.CreatePage(ПрихіднийКасовийОрдер_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vRight, РозхіднийКасовийОрдер_Const.FULLNAME, async () =>
            {
                РозхіднийКасовийОрдер_Список page = new();
                NotebookFunc?.CreatePage(РозхіднийКасовийОрдер_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vRight, КорегуванняБоргу_Const.FULLNAME, async () =>
            {
                КорегуванняБоргу_Список page = new();
                NotebookFunc?.CreatePage(КорегуванняБоргу_Const.FULLNAME,  page);
                await page.SetValue();
            });
        }

        {
            CreateCaptionLink(vRight, "Склад", async () =>
            {
                /*Журнал_Склад page = new Журнал_Склад();
                NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, "Склад", () => page);
                await page.SetValue();*/
            });

            CreateLink(vRight, ПереміщенняТоварів_Const.FULLNAME, async () =>
            {
                ПереміщенняТоварів_Список page = new();
                NotebookFunc?.CreatePage(ПереміщенняТоварів_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vRight, ВведенняЗалишків_Const.FULLNAME, async () =>
            {
                ВведенняЗалишків_Список page = new();
                NotebookFunc?.CreatePage(ВведенняЗалишків_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vRight, ВнутрішнєСпоживанняТоварів_Const.FULLNAME, async () =>
            {
                ВнутрішнєСпоживанняТоварів_Список page = new();
                NotebookFunc?.CreatePage(ВнутрішнєСпоживанняТоварів_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vRight, ПсуванняТоварів_Const.FULLNAME, async () =>
            {
                ПсуванняТоварів_Список page = new();
                NotebookFunc?.CreatePage(ПсуванняТоварів_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vRight, ПерерахунокТоварів_Const.FULLNAME, async () =>
            {
                ПерерахунокТоварів_Список page = new();
                NotebookFunc?.CreatePage(ПерерахунокТоварів_Const.FULLNAME, page);
                await page.SetValue();
            });
        }

        {
            CreateCaptionLink(vRight, "Адресне зберігання", async () =>
            {
                /*Журнал_АдреснеЗберігання page = new Журнал_АдреснеЗберігання();
                NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, "Адресне зберігання", () => page);
                await page.SetValue();*/
            });

            CreateLink(vRight, РозміщенняТоварівНаСкладі_Const.FULLNAME, async () =>
            {
                РозміщенняТоварівНаСкладі_Список page = new();
                NotebookFunc?.CreatePage(РозміщенняТоварівНаСкладі_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vRight, ЗбіркаТоварівНаСкладі_Const.FULLNAME, async () =>
            {
                ЗбіркаТоварівНаСкладі_Список page = new();
                NotebookFunc?.CreatePage(ЗбіркаТоварівНаСкладі_Const.FULLNAME, page);
                await page.SetValue();
            });

            CreateLink(vRight, ПереміщенняТоварівНаСкладі_Const.FULLNAME, async () =>
            {
                ПереміщенняТоварівНаСкладі_Список page = new();
                NotebookFunc?.CreatePage(ПереміщенняТоварівНаСкладі_Const.FULLNAME, page);
                await page.SetValue();
            });
        }
    }
}