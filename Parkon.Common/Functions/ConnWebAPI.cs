using Prkn.Common.Variables;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Prkn.Common.Functions
{
    public static class ConnWebAPI
    {
        public static string UserLoginCheck(string UserName, string Password, out string StatusCode, out string UserId)
        {
            var httpWebRequest      = (HttpWebRequest)WebRequest.Create(Var_JSON.URI.Token);
            var UName               = Crypto.Encrypt(UserName, Global.Str_ProjeCrypto);
            var UPass               = Crypto.Encrypt(Password, Global.Str_ProjeCrypto);

            //var d1 = Crypto.Decrypt(UName, Global.Str_ProjeCrypto);
            //var d2 = Crypto.Decrypt(UPass, Global.Str_ProjeCrypto);

            httpWebRequest.ContentType      = "application/x-www-form-urlencoded";
            httpWebRequest.Method           = "POST";
            httpWebRequest.Headers.Add("m1:" + "68973480-8df4-4344-b08b-2a8635bae61b");
            httpWebRequest.Headers.Add("m2:" + UName);
            httpWebRequest.Headers.Add("m3:" + UPass);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "grant_type=password";
                streamWriter.Write(json);
            }

            try
            {
                var httpResponse    = (HttpWebResponse)httpWebRequest.GetResponse();
                StatusCode          = httpResponse.StatusCode.ToString();

                if (StatusCode == HttpStatusCode.OK.ToString())
                {
                    string ID = string.Empty;
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result          = streamReader.ReadToEnd();
                        JObject jObject     = Newtonsoft.Json.Linq.JObject.Parse(result);
                        var token           = jObject.SelectToken("access_token");
                        Var_JSON.TokenKey   = token.Value<string>();

                        var UserID          = jObject.SelectToken("Id");
                        UserId              = UserID.Value<string>();
                    }
                    Thread.Sleep(250);
                }
                else
                {
                    UserId = null;
                }
            }
            catch (WebException we)
            {
                StatusCode  = ((HttpWebResponse)we.Response).StatusCode.ToString();
                UserId      = null;
            }

            return StatusCode;
        }

        public static string SET_Post(string URI, object Body_Json, out string Json)
        {
            Json = string.Empty;
            string Result = string.Empty;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(URI);
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Authorization:" + " Bearer " + Var_JSON.TokenKey);
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(Body_Json);
            }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Result = httpResponse.StatusCode.ToString();

                if (Result == HttpStatusCode.Created.ToString())
                {
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        Json = streamReader.ReadToEnd();
                    }
                }
            }
            catch (WebException we)
            {
                Result = ((HttpWebResponse)we.Response).StatusCode.ToString();
            }
            return Result;
        }
        public static string SET_Put(string URI, object Body_Json)
        {
            string Result = string.Empty;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(URI);
            httpWebRequest.Method = "PUT";
            httpWebRequest.Headers.Add("Authorization:" + " Bearer " + Var_JSON.TokenKey);
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(Body_Json);
            }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Result = httpResponse.StatusCode.ToString();
            }
            catch (WebException we)
            {
                Result = ((HttpWebResponse)we.Response).StatusCode.ToString();
            }
            return Result;
        }
        public static string SET_Delete(string URI, out string Json)
        {
            Json = string.Empty;
            string Result = string.Empty;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(URI);
            httpWebRequest.Method = "DELETE";
            httpWebRequest.Headers.Add("Authorization:" + " Bearer " + Var_JSON.TokenKey);
            httpWebRequest.ContentType = "application/json";

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Result = httpResponse.StatusCode.ToString();

                if (Result == HttpStatusCode.OK.ToString())
                {
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        Json = streamReader.ReadToEnd();
                    }
                }
            }
            catch (WebException we)
            {
                Result = ((HttpWebResponse)we.Response).StatusCode.ToString();
            }
            return Result;
        }
        public static string SET_Get(string URI, out string Json)
        {
            Json                    = string.Empty;
            string Result           = string.Empty;
            string _uri = string.Empty;
            if (URI.IndexOf("?$filter") > 0)
            {
                _uri = URI + " and " + "VarStatus ne 'Deleted'";
            }
            else
            {
                _uri = URI + "?$filter=VarStatus ne 'Deleted'";
            }

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(_uri); // URI + "?$filter=VarStatus ne 'Deleted'" );// + " ? filter=Deleted");   //@"?$filter=Id eq " + InsertDataInfo.CustomerId + "L"
            httpWebRequest.Method   = "GET";
            httpWebRequest.Timeout  = 5000;
            httpWebRequest.Headers.Add("Authorization:" + " Bearer " + Var_JSON.TokenKey);
            httpWebRequest.ContentType = "application/json";

            try
            {
                var httpResponse    = (HttpWebResponse)httpWebRequest.GetResponse();
                Result              = httpResponse.StatusCode.ToString();

                if (Result == HttpStatusCode.OK.ToString())
                {
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        Json = streamReader.ReadToEnd();
                    }
                }
                else
                {
                    Result = httpResponse.StatusCode.ToString();
                }
            }
            catch (WebException we)
            {
                if (we.Response != null)
                {
                    if (!string.IsNullOrEmpty(((HttpWebResponse)we.Response).StatusCode.ToString()))
                    {
                        Result = ((HttpWebResponse)we.Response).StatusCode.ToString();
                    }
                    else
                    {
                        Result = string.Empty;
                    }
                }
                else
                {
                    Result = string.Empty;
                }
            
            }
            return Result;
        }

        #region IMAGE
        public static string UploadImage(string URI, string imagePath, string imageName, out string Status)
        {
            Status = string.Empty;
            string StatusCode = string.Empty;
            Bitmap myImage = new Bitmap(imagePath);

            byte[] myFileData = (byte[])(new ImageConverter()).ConvertTo(myImage, typeof(byte[]));
            string myBoundary = "---------------------------7df3c13714f0ffc";
            var newLine = Environment.NewLine;
            string myContent =
                                     "--" + myBoundary + newLine +
                                     "Content-Disposition: form-data; name=\"image\"; filename=\"" + imageName + "\"" + newLine +
                                     "Content-Type: image/jpeg" + newLine +
                                     newLine +
                                     Encoding.Default.GetString(myFileData) + newLine +
                                     "--" + myBoundary + "--";

            using (var client = new WebClient())
            {
                try
                {
                    client.Headers["Authorization"] = "Bearer " + Var_JSON.TokenKey;
                    client.Headers["Content-Type"] = "multipart/form-data; boundary=" + myBoundary;
                    client.UploadString(new Uri(URI), "POST", myContent);
                    StatusCode = GetStatusCode(client, out Status).ToString();
                }
                catch
                {
                    StatusCode = GetStatusCode(client, out Status).ToString();
                }
            }
            return Status;
        }
        private static int GetStatusCode(WebClient client, out string statusDescription)
        {
            FieldInfo responseField = client.GetType().GetField("m_WebResponse", BindingFlags.Instance | BindingFlags.NonPublic);

            if (responseField != null)
            {
                HttpWebResponse response = responseField.GetValue(client) as HttpWebResponse;

                if (response != null)
                {
                    statusDescription = response.StatusDescription;
                    return (int)response.StatusCode;
                }
            }

            statusDescription = null;
            return 0;
        }
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public static string DownloadImage(string URI, string imageName, string ImageFolderPath)
        {
            //     File.Exists(ImageFolderPath)
            string Filepath = ImageFolderPath + "" + imageName;
            string URIFull = URI + "?name=" + imageName; //api/image/user/d?name=IMG001.jpg
            if (!File.Exists(Filepath))
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers["Authorization"] = "Bearer " + Var_JSON.TokenKey;
                    //client.Headers["Content-Type"] = "multipart/form-data;";// boundary=" + myBoundary;
                    //client.UploadString(new Uri(URI), "GET");

                    client.DownloadProgressChanged += wc_DownloadProgressChanged;
                    client.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri(URIFull),
                        // Param2 = Path to save
                        //"D:\\Images\\front_view.jpg"
                        Filepath
                    );
                }
            }



            return "OK";
        }
        public static void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBar pb = new ProgressBar();
            pb.Value = e.ProgressPercentage;
        }
        #endregion

    }
}
