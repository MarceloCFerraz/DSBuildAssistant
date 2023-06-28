using DSR.Models.Attributes;

namespace DSR.Models.Upgrade;

public class WeaponUpgrade : WeaponAttributes
{
    public int WeaponID { get; set; }
    public UpgradePath Path { get; set; }
    public UpgradeStage Stage { get; set; }
}