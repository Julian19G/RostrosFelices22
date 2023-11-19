namespace RostrosFelices.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Empleado { get; set; }


        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
    }
}
