namespace DSR.Models.Attributes;

public class WeaponAttributes
{
    public string? Name { get; set; }
    public int CriticalBonus { get; set; }
    public int Stability { get; set; }
    public int Durability { get; set; }
    public double Weight { get; set; }
    public int StrenghtRequirement { get; set; }
    public int DexterityRequirement { get; set; }
    public int IntelligenceRequirement { get; set; }
    public int FaithRequirement { get; set; }
    public int PhysicalDamage { get; set; }
    public int MagicalDamage { get; set; }
    public int FireDamage { get; set; }
    public int LightningDamage { get; set; }
    public int DivineDamage { get; set; }
    public int OccultDamage { get; set; }
    public Scale StrengthScale { get; set; }
    public Scale DexterityScale { get; set; }
    public Scale IntelligenceScale { get; set; }
    public Scale FaithScale { get; set; }
    public int PhysicalDefense { get; set; }
    public int MagicalDefense { get; set; }
    public int FireDefence { get; set; }
    public int LightningDefence { get; set; }
}