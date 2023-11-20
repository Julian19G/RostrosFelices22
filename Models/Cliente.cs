namespace RostrosFelices.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Servicio>? Servicios { get; set; } = default!;
    }
}