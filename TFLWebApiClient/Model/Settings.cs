using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLWebApiClient.Model
{
    public class Settings
    {
        public required string AppId { get; set; }
        public required string AppKey { get; set; }
        public required string BaseUrl { get; set; }
    }
}
