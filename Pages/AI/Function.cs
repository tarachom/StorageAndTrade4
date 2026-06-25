using System.ComponentModel;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;
using AccountingSoftware;

namespace StorageAndTrade.AI;

static class Function
{
    /// <summary>
    /// Функція пошуку Guid валюти за її ISO кодом
    /// </summary>
    [Description("Отримує внутрішній унікальний ідентифікатор (Guid) валюти за її міжнародним трилітерним кодом ISO 4217.")]
    public static async Task<string> ОтриматиІдВалюти(
        [Description("Міжнародний код валюти в форматі ISO 4217. Наприклад: 'UAH' для грн/гривні, 'USD' для долара, 'EUR' для євро.")]
        string isoCode)
    {
        Console.WriteLine($"[БД] Виклик пошуку Guid для ISO коду: {isoCode}");
        return (await new Валюти_Select().FindByField(Валюти_Const.КороткаНазва, isoCode.ToUpper())).UniqueID.ToString();
    }

    /// <summary>
    /// Пошук Guid категорії/папки
    /// </summary>
    [Description("Повертає внутрішній Guid папки (категорії) за її текстовою назвою.")]
    public static async Task<string> ОтриматиІдПапкиНоменклатури(
        [Description("Назва папки чи категорії, яку вказав користувач, наприклад: 'Продукти', 'Тара', 'Одяг'.")]
        string categoryName)
    {
        Console.WriteLine($"[БД] Пошук Guid для папки номенклатури: {categoryName}");
        return (await new Номенклатура_Папки_Select().FindByField(Номенклатура_Папки_Const.Назва, categoryName.ToLower(), "LOWER")).UniqueID.ToString();
    }

    /// <summary>
    /// get_unit_guid
    /// Пошук Guid одиниці виміру з нормалізацією назви
    /// </summary>
    [Description("Повертає внутрішній Guid одиниці виміру. Нормалізує розмовні назви до стандартних скорочень")]
    public static async Task<string> ОтриматиІдПакуванняОдиниціВиміру(
        [Description(@"Назва одиниці виміру. Приведи її до стандартного вигляду:
        для 'штука/штуки/шт' = 'шт'; для 'кілограм/кг' = 'кг'; для 'метр/метри/м' = 'м'.
        Все інше буде як задано")]
        string unitName)
    {
        Console.WriteLine($"[БД] Пошук Guid для одиниці виміру: {unitName}");
        return (await new ПакуванняОдиниціВиміру_Select().FindByField(ПакуванняОдиниціВиміру_Const.Назва, unitName.ToLower(), "LOWER")).UniqueID.ToString();
    }

    /// <summary>
    /// Функція збереження списку товарів
    /// </summary>
    [Description("Створює та зберігає список товарів у вказаних категоріях.")]
    public static async Task<bool> СтворитиНоменклатуру(
        [Description("Список об'єктів товарів для створення")]
        List<Номенклатура> products)
    {
        Console.WriteLine($"[БД] Отримано запит на створення {products.Count} товарів:");

        foreach (var prod in products)
        {
            Номенклатура_Object Обєкт = new();
            await Обєкт.New();
            Обєкт.Назва = prod.Назва;
            Обєкт.НазваПовна = prod.Назва;
            Обєкт.Артикул = prod.Артикул;
            Обєкт.ТипНоменклатури = ПсевдонімиПерелічення.ТипиНоменклатури_FindByName(prod.Тип);
            Обєкт.ВидНоменклатури = await new ВидиНоменклатури_Select().FindByField(ВидиНоменклатури_Const.Назва, prod.Тип switch { "Товар" => "Товари", "Послуга" => "Послуги", _ => "Товари" });
            Обєкт.Папка = new Номенклатура_Папки_Pointer(new UniqueID(prod.Папка));
            Обєкт.ОдиницяВиміру = new ПакуванняОдиниціВиміру_Pointer(new UniqueID(prod.ОдиницяВиміру));
            await Обєкт.Save();

            await Номенклатура_Функції.OpenPageElement(false, Обєкт.UniqueID);

            Console.WriteLine($"-> Збережено: {prod.Назва} | Тип: {prod.Тип} | Папка: {prod.Папка} | Од: {prod.ОдиницяВиміру} Артикул: {prod.Артикул}");
        }

        return true;
    }




}