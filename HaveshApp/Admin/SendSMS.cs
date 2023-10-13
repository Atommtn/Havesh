using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using static MudBlazor.CategoryTypes;
using System;
using System.Net;
using System.Text;
using Olive;
using ShokouhApp.Model;

namespace ShokouhApp.Admin
{
    public class SendSMS
    {
//        string SendSms(ShokouhPardisStudentClass student)
//        {

//            var cell = (from c in student.FatherPhone
//                where c.InsContact.ContactTypeFk == 2
//                select c.InsContact).FirstOrDefault();

//            Uri address = new Uri("http://panel.asanak.ir/webservice/v1rest/sendsms");

//            // Create the web request
//            HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;

//            // Set type to POST
//            request.Method = "POST";
//            request.ContentType = "application/x-www-form-urlencoded";

//            // Create the data we want to send
//            StringBuilder data = new StringBuilder();
//            data.Append("username=" + "m.tayefenafar@3824");
//            data.Append("&password=" + "frzmtn");
//            data.Append("&source=" + "982176283824");
//            data.Append("&destination=" + cell.ContactValue);
//            data.Append("&message=" + string.Format(@"همکار گرامی {0}
//حساب کاربری شما در انتظار تایید مدیر سایت می باشد.
//", student.InsEmployee.InsPerson.Name + " " + student.InsEmployee.InsPerson.Famil));

//            // Create a byte array of the data we want to send
//            byte[] byteData = UTF8Encoding.UTF8.GetBytes(data.ToString());

//            // Set the content length in the request headers
//            request.ContentLength = byteData.Length;

//            // Write data
//            using (Stream postStream = request.GetRequestStream())
//            {
//                postStream.Write(byteData, 0, byteData.Length);
//            }

//            // Get response
//            var result = "";
//            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
//            {
//                StreamReader reader = new StreamReader(response.GetResponseStream());
//                result = reader.ReadToEnd();
//            }
//            validationContactEntity.CellStatus = result;
//            return result;
//        }

    }
}
