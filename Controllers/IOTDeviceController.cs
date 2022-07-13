using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyIOTHUB301.Models;

namespace MyIOTHUB301.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IoTDeviceController : ControllerBase
    {
       [HttpPost]
       [Route("AddDevice")]
       public async Task AddDevice(string deviceId)
       {
            await IOTDevice.AddDeviceAsync(deviceId);
       }
       
       [HttpGet]
       [Route("GetDevice")]
       public async Task GetDevice(string deviceId)
       {
            await IOTDevice.GetDeviceAsync(deviceId);
       }

       [HttpDelete]
       [Route("DeleteDevice")]
       public async Task DeleteDevice(string deviceId)
       {
            await IOTDevice.RemoveDeviceAsync(deviceId);
       }

       [HttpPut]
       [Route("UpdateDevice")]
       public async Task UpdateDevice(string deviceId)
       {
            await IOTDevice.UpdateDeviceAsync(deviceId);
       }

    }   
}