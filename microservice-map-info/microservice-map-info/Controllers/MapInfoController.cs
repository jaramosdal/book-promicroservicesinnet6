using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleMapInfo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace microservice_map_info.Controllers;

[Route("[controller]")]
[Route("[controller]/[action]")]
[ApiController] public class MapInfoController : ControllerBase
{
    private readonly GoogleDistanceApi _googleDistanceApi;
    public MapInfoController(GoogleDistanceApi googleDistanceApi)
    {
        _googleDistanceApi = googleDistanceApi;
    }

    [HttpGet]
    public async Task<GoogleDistanceData> GetDistance(string originCity, string destinationCity)
    {
        return await _googleDistanceApi.GetMapDistance(originCity, destinationCity);
    }
}