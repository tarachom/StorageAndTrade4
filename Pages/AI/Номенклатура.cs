using System.ComponentModel;

namespace StorageAndTrade.AI;

public class Номенклатура
{
    [Description(@"Назва товару або послуги, наприклад: 
    Шуба, Кросівки, Доставка. Назва має починатися з великої букви. 
    Виправляй помилки правопису при можливості.")]
    public string Назва { get; set; } = string.Empty;

    [Description("Товар або Послуга. Якщо неможливо визначити тоді стандартно Товар")]
    public string Тип { get; set; } = string.Empty;

    [Description("Внутрішній Guid одиниці виміру. Його обов'язково потрібно заздалегідь отримати через функцію 'get_unit_guid'")]
    public string? ОдиницяВиміру { get; set; }

    [Description("Внутрішній Guid папки (категорії) товару. Його обов'язково потрібно заздалегідь отримати через функцію 'get_category_guid'")]
    public string? Папка { get; set; }

    [Description("Артикул для товару")]
    public string Артикул { get; set; } = string.Empty;
}