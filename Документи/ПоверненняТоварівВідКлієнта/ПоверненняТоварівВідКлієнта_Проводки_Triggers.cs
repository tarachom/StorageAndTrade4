

/*
        ПоверненняТоварівВідКлієнта_Проводки_Triggers.cs
        Тригери табличної частини Проводки
*/

using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПоверненняТоварівВідКлієнта_Проводки_Triggers
{
    public static Task BeforeSave(ПоверненняТоварівВідКлієнта_Object ДокументОбєкт, ПоверненняТоварівВідКлієнта_Проводки_TablePart ТабличнаЧастина)
    {
        return Task.CompletedTask;
    }

    public static async Task AfterSave(ПоверненняТоварівВідКлієнта_Object ДокументОбєкт, ПоверненняТоварівВідКлієнта_Проводки_TablePart ТабличнаЧастина)
    {
        if (!ДокументОбєкт.ДокументБухгалтерськаОперація.IsEmpty())
        {
            var БухОперація = await ДокументОбєкт.ДокументБухгалтерськаОперація.GetDocumentObject();
            if (БухОперація != null)
            {
                foreach (var record in ТабличнаЧастина.Records)
                    БухОперація.Операції_TablePart.Records.Add(new()
                    {
                        ДатаЗапису = ДокументОбєкт.ДатаДок,

                        Рахунок = record.Рахунок,
                        Аналітика1 = record.Аналітика1,
                        Аналітика2 = record.Аналітика2,
                        Аналітика3 = record.Аналітика3,
                        Дебет = record.Дебет,
                        Кредит = record.Кредит,
                        Податок = record.Податки,

                        ВалютаДебет = ДокументОбєкт.Валюта,
                        ВалютаКредит = ДокументОбєкт.Валюта,
                    });

                await БухОперація.Операції_TablePart.Save(true);
            }
        }
    }
}
