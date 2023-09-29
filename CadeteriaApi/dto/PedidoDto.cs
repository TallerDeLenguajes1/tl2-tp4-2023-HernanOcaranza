namespace CadeteriaApi
{
    public class PedidoDto
    {                     
        public class Post
        {
            public string Nombre { get; set; }
            public string Observacion { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string DatosReferenciaDireccion { get; set; }
        }
    }
}