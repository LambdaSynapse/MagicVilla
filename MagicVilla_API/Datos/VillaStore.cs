using MagicVilla_API.Modelos.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto> 
        { 
            new VillaDto{ Id=1,Nombre="Vista de la piscina", MetrosCuadrados = 23, Ocupantes = 12},
            new VillaDto{ Id=2, Nombre="Vista de la playa ", MetrosCuadrados = 22, Ocupantes = 4 }
        };
    }
}
