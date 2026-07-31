using System.Diagnostics;
namespace Azazel_api.DTOs;
using Azazel_api.Models;
public class AccionDTO
{
    public int IdAccion {get; set;}
    public int IdUsuario {get; set;}
    public int IdConversacion {get; set;}
    public EnumAcciones TipoAccion {get; set;}
    public bool Exito {get; set;}
    public Stopwatch TimeResponse {get; set;}
}