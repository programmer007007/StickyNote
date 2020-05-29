using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StickyNote
{
    class Helper
    {
        public static string dirPath = "";
        public static DriveService driveService = null;
        public static string parentFolder = "";
        public static FileInfo getLastCreatedFile()
        {
            if (dirPath == "")
            {
                MessageBox.Show("No Default Path Set. Kindly Set it");
                return null;
            }
            
            FileInfo myFile = null;
            var directory = new DirectoryInfo(dirPath);
            try
            {
                myFile = (from f in directory.GetFiles() 
                    orderby f.LastWriteTime descending
                    select f).First();
               

            }
            catch (Exception esException)
            {
                Console.WriteLine(esException.StackTrace);
            }

            return myFile;
        }




        public static DriveService Authorize(string clientId, string clientSecret)
        {
            string[] scopes = new string[] { DriveService.Scope.Drive,  
                DriveService.Scope.DriveFile,};           
           
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            }, scopes,
                Environment.UserName, CancellationToken.None, new FileDataStore("MyAppsToken")).Result;
           

            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "StickyNote",

            });
            service.HttpClient.Timeout = TimeSpan.FromMinutes(100);
                     return service;

        }

        public static string GetMimeType(string fileName)
        {
            
            string mimeType = "application/unknown"; string ext = System.IO.Path.GetExtension(fileName).ToLower(); Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext); if (regKey != null && regKey.GetValue("Content Type") != null) mimeType = regKey.GetValue("Content Type").ToString(); System.Diagnostics.Debug.WriteLine(mimeType); return mimeType;
        }
        public static Google.Apis.Drive.v3.Data.File uploadFile(DriveService _service, string _uploadFile, string _parent, string _descrp = "")
        {
            if (System.IO.File.Exists(_uploadFile))
            {
                Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
                body.Name = System.IO.Path.GetFileName(_uploadFile);
                body.Description = _descrp;
                body.MimeType = GetMimeType(_uploadFile);
              
                body.Parents = new List<string> { _parent };// UN comment if you want to upload to a folder(ID of parent folder need to be send as paramter in above method)
                byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    FilesResource.CreateMediaUpload request = _service.Files.Create(body, stream, GetMimeType(_uploadFile));
                    request.SupportsTeamDrives = true;
                    request.Upload();
                    return request.ResponseBody;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message, "Error Occured");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.", "404");
                return null;
            }
        }
    }
}
