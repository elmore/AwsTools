using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

namespace SnsMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            AmazonSimpleNotificationServiceClient snsClient = new AmazonSimpleNotificationServiceClient(Amazon.RegionEndpoint.EUWest1);

            //SubscribeRequest subRequest = new SubscribeRequest("", );
        }
    }
}
