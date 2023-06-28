using DSR.Models.Attributes;

namespace DSR.Models.Upgrade;

public class ArmorUpgrade : ArmorAttributes
{
    public int ArmorID { get; set; }
    public UpgradeStage Stage { get; set; }
}