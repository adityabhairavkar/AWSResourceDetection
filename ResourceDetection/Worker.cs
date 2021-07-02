using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace ResourceDetection
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            string Hostname = Amazon.Util.EC2InstanceMetadata.Hostname;
            string InstanceId = Amazon.Util.EC2InstanceMetadata.InstanceId;
            string InstanceType = Amazon.Util.EC2InstanceMetadata.InstanceType;
            string LocalHostname = Amazon.Util.EC2InstanceMetadata.LocalHostname;
            string MacAddress = Amazon.Util.EC2InstanceMetadata.MacAddress;
            string AvailabilityZone = Amazon.Util.EC2InstanceMetadata.AvailabilityZone;
            string UserData = Amazon.Util.EC2InstanceMetadata.UserData;


            _logger.LogInformation("Hostname: {name} , InstanceId :{InstanceId} , InstanceType :{InstanceType} ," +
                " LocalHostname :{LocalHostname} , MacAddress : {MacAddress} ,AvailabilityZone : {AvailabilityZone}, UserData : {UserData}"
                , Hostname , InstanceId , InstanceType , LocalHostname, MacAddress, AvailabilityZone , UserData);

        }
    }
}
