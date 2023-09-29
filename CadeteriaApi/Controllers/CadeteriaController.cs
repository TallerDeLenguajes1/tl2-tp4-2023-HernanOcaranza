using Microsoft.AspNetCore.Mvc;
using CadeteriaLibrary;

namespace CadeteriaApi.Controllers;

[ApiController]
[Route("[api/v1/cadeteria]")]
public class CadeteriaController : ControllerBase
{        
    private readonly Cadeteria _cadeteria;
    public CadeteriaController(Cadeteria cadeteria)
    {
        _cadeteria = cadeteria;
    }

    /*
    [Get] GetPedidos() => Retorna una lista de Pedidos
● [Get] GetCadetes() => Retorna una lista de Cadetes
● [Get] GetInforme() => Retorna un objeto Informe
● [Post] AgregarPedido(Pedido pedido)
● [Put] AsignarPedido(int idPedido, int idCadete)
● [Put] CambiarEstadoPedido(int idPedido,int NuevoEstado)
● [Put] CambiarCadetePedido(int idPedido,int idNuevoCadete)

    */    
    [HttpGet("pedido")]
    public IActionResult GetPedidos()
    {
        var res = _cadeteria.ListarPedidos();
        return Ok(res);
    }

    [HttpGet("cadete")]
    public IActionResult GetCadetes()
    {
        var res = _cadeteria.ListarCadetes();
        return Ok(res);
    }

    [HttpPost("pedido")]
    public IActionResult AgregarPedido(PedidoDto.Post pedido)
    {
        _cadeteria.CrearPedido(pedido.Observacion, 
            pedido.Nombre, 
            pedido.Direccion, 
            pedido.Telefono, 
            pedido.DatosReferenciaDireccion);
        return Ok();
    }

}
