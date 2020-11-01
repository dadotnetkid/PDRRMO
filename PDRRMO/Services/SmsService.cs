using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDRRMO.Services
{
    public enum SmsReturnStatus
    {
        Sent=0,
        Failed=1
    }
    public class SmsService
    {
        
        public SmsReturnStatus Send(string number,string message)
        {
            object functionReturnValue = null;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                System.Collections.Specialized.NameValueCollection parameter = new System.Collections.Specialized.NameValueCollection();
                string url = "https://www.itexmo.com/php_api/api.php";
                parameter.Add("1", number);
                parameter.Add("2", message);
                parameter.Add("3", "PR-PLGUN355481_KR8GY");
                parameter.Add("passwd", "t}%7yvic6v");
                dynamic rpb = client.UploadValues(url, "POST", parameter);
                functionReturnValue = (new System.Text.UTF8Encoding()).GetString(rpb);
            }
            
            if (functionReturnValue == "0")
            {
                return SmsReturnStatus.Sent;
            }
            return SmsReturnStatus.Failed;
        }
    }
}
