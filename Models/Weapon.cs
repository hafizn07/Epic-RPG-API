namespace Epic_RPG_API.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Damage { get; set; }
        public Character? Character { get; set; }
        public int CharacterId { get; set; }
    }
}
