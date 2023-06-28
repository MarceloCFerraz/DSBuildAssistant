using DSR.Models.Attributes;

namespace DSR.Models.Upgrade;

public class ShieldUpgrade : ShieldAttributes
{
    public int ShieldID { get; set; }
    public UpgradePath Path { get; set; }
    public UpgradeStage Stage { get; set; }
}