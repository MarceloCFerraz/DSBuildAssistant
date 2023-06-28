using DSR.Models.Attributes;

namespace DSR.Models;

public class Armor : ArmorAttributes
{
    public int ID { get; set; }
    public ArmorType Type { get; set; }
}