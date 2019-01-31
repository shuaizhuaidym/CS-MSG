using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Net;
using System.IO;

namespace CS_MSG.util {

    class HttpClient {
        private static string method_post = "POST";

        public static string doPost(string url, string postData) {
            string responseFromServer = null;
            CS_MSG.util.Logger.debug("CS_MSG.util.HttpClient", "dopost");
            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create(url);

            // Set the Method property of the request to POST.  
            request.Method = method_post;
            // Create POST data and convert it to a byte array. 
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;
            // Get the request stream.  
            Stream dataStream = null;
            WebResponse response = null;
            StreamReader reader = null;
            try {
                dataStream = request.GetRequestStream();
                // Write the data to the request stream.  
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.  
                dataStream.Close();
                // Get the response.  
                response = request.GetResponse();

                HttpStatusCode resultCode = ((HttpWebResponse)response).StatusCode;

                if(resultCode.Equals(HttpStatusCode.OK)){
                    responseFromServer = ((HttpWebResponse)response).StatusDescription;
                }else{
                    // Get the stream containing content returned by the server.  
                    dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.  
                    reader = new StreamReader(dataStream);
                    // Read the content.  
                    responseFromServer = reader.ReadToEnd();                    
                }
            } catch (IOException ioe) {
                 responseFromServer=ioe.Message;
            } catch(Exception e){
                responseFromServer = e.Message;
            } finally {
                // Clean up the streams.
                try {
                    if (reader != null) { reader.Close(); }
                    if (dataStream != null) { dataStream.Close(); }
                    if (response != null) { response.Close(); }    
                } catch (Exception e) {
                    //ignore exception
                }
            }
            // Display the content.  
            Console.WriteLine(responseFromServer);
            return responseFromServer;
        }

        /**post method 2*/
        public static void decryptContainer(string dlc_content) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dcrypt.it/decrypt/paste");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

            byte[] _byteVersion = Encoding.ASCII.GetBytes(string.Concat("content=", dlc_content));

            request.ContentLength = _byteVersion.Length;

            Stream stream = request.GetRequestStream();
            stream.Write(_byteVersion, 0, _byteVersion.Length);
            stream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream())) {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
