namespace api.clientes.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public int Idciudad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nro_Documento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Ciudad { get; set; }
        public string Nacionalidad { get; set; }
        public int Edad { get; set; }
    }
}
