using FabricApplication.Models.DAL;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Web.Http;

namespace FabricApplication.Controllers
{
    public class DocumentUploadController : ApiController
    {
        string rootPath;

        private readonly ServiceFabricEntities7 dbcontext = new ServiceFabricEntities7();
        //public DocumentUploadController()
        //{
        //    //The Path of the Image store on the server side
        //    rootPath = HostingEnvironment.MapPath("~/ClientDocument/");
        //}

        //[Route("api/Files")]
        //public List<FilesInfo> GetFiles()
        //{
        //    List<FilesInfo> files = new List<FilesInfo>();

        //    foreach (var item in Directory.GetFiles(rootPath))
        //    {
        //        FileInfo f = new FileInfo(item);
        //        files.Add(new FilesInfo() {FileName = f.Name });
        //    }
        //    return files;
        //}

        /// <summary>  
        /// Upload Document.....  
        /// </summary>        
        /// <returns></returns>  

        [Route("api/MediaUpload")]
        [HttpPost]
        public async Task<HttpResponseMessage> MediaUpload(string TeamId,string matchid)
        {
            //// Check if the request contains multipart/form-data.  
            //if (!Request.Content.IsMimeMultipartContent())
            //{
            //    throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            //}

            //var provider = await Request.Content.ReadAsMultipartAsync<InMemoryMultipartFormDataStreamProvider>(new InMemoryMultipartFormDataStreamProvider());
            ////access form data  
            //NameValueCollection formData = provider.FormData;
            ////access files  
            //IList<HttpContent> files = provider.Files;

            //HttpContent file1 = files[0];
            //var thisFileName = file1.Headers.ContentDisposition.FileName.Trim('\"');

            //string filename = String.Empty;
            //Stream input = await file1.ReadAsStreamAsync();
            //string directoryName = String.Empty;
            //string URL = String.Empty;
            //string tempDocUrl = WebConfigurationManager.AppSettings["DocsUrl"];

            //var path = HttpRuntime.AppDomainAppPath;
            //directoryName = System.IO.Path.Combine(path, "ClientDocument");
            //filename = System.IO.Path.Combine(directoryName, thisFileName);

            ////Deletion exists file  
            //if (File.Exists(filename))
            //{
            //    File.Delete(filename);
            //}

            //string DocsPath = tempDocUrl + "/" + "ClientDocument" + "/";
            //URL = DocsPath + thisFileName;

            ////Directory.CreateDirectory(@directoryName);  
            //using (Stream file = File.OpenWrite(filename))
            //{
            //    input.CopyTo(file);
            //    //close file  
            //    file.Close();
            //}

            //var response = Request.CreateResponse(HttpStatusCode.OK);
            //response.Headers.Add("DocsUrl", URL);
            //return response;

            Dictionary<string, object> dict = new Dictionary<string, object>();
            try
            {
                var httpRequest = HttpContext.Current.Request;
                foreach (string file in httpRequest.Files)
                {
                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
                    var postedFile = httpRequest.Files[file];
                    if (postedFile != null && postedFile.ContentLength > 0)
                    {
                        int MaxContentLength = 1024 * 1024 * 1; //Size = 1 MB
                        IList<string> AllowedFileExtensions = new List<string> { ".jpg", ".gif", ".png" };
                        var ext = postedFile.FileName.Substring(postedFile.FileName.LastIndexOf('.'));
                        var originalFilename = Path.GetFileName(postedFile.FileName);
                        var extension = ext.ToLower();
                        if (!AllowedFileExtensions.Contains(extension))
                        {
                            var message = string.Format("Please Upload image of type .jpg,.gif,.png.");
                            dict.Add("error", message);
                            return Request.CreateResponse(HttpStatusCode.BadRequest, dict);
                        }
                        else if (postedFile.ContentLength > MaxContentLength)
                        {
                            var message = string.Format("Please Upload a file upto 1 mb.");
                            dict.Add("error", message);
                            return Request.CreateResponse(HttpStatusCode.BadRequest, dict);
                        }
                        else
                        {
                            string fileId = Guid.NewGuid().ToString().Replace("-", "");
                            //if needed write the code to update the table
                            var filePath = HttpContext.Current.Server.MapPath("~/ClientDocument/" + fileId + originalFilename);
                            postedFile.SaveAs(filePath);

                            TeamLog teamlogo = new TeamLog()
                            {
                                TeamId = Convert.ToInt32(TeamId),
                                MatchId = Convert.ToInt32(matchid),
                                TeamLogs = Convert.ToString("http://idtp285/ClientDocument/" + fileId + originalFilename)
                            };
                            dbcontext.TeamLogs.Add(teamlogo);
                            dbcontext.SaveChanges();
                        }
                    }
                    var message1 = string.Format("Image Updated Successfully.");
                    return Request.CreateErrorResponse(HttpStatusCode.Created, message1); ;
                }
                var res = string.Format("Please Upload a image.");
                dict.Add("error", res);
                return Request.CreateResponse(HttpStatusCode.NotFound, dict);
            }
            catch (Exception ex)
            {
                var res = string.Format("some Message");
                dict.Add("error", res);
                return Request.CreateResponse(HttpStatusCode.NotFound, dict);
            }
        }

        [Route("api/UploadPlayerImage/{playerid}")]
        [HttpPost]
        public async Task<HttpResponseMessage> UploadPlayerImage(int playerid)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            try
            {
                var httpRequest = HttpContext.Current.Request;
                foreach (string file in httpRequest.Files)
                {
                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
                    var postedFile = httpRequest.Files[file];
                    if (postedFile != null && postedFile.ContentLength > 0)
                    {
                        int MaxContentLength = 1024 * 1024 * 1; //Size = 1 MB
                        IList<string> AllowedFileExtensions = new List<string> { ".jpg", ".gif", ".png" };
                        var ext = postedFile.FileName.Substring(postedFile.FileName.LastIndexOf('.'));
                        var originalFilename = Path.GetFileName(postedFile.FileName);
                        var extension = ext.ToLower();
                        if (!AllowedFileExtensions.Contains(extension))
                        {
                            var message = string.Format("Please Upload image of type .jpg,.gif,.png.");
                            dict.Add("error", message);
                            return Request.CreateResponse(HttpStatusCode.BadRequest, dict);
                        }
                        else if (postedFile.ContentLength > MaxContentLength)
                        {
                            var message = string.Format("Please Upload a file upto 1 mb.");
                            dict.Add("error", message);
                            return Request.CreateResponse(HttpStatusCode.BadRequest, dict);
                        }
                        else
                        {
                            string fileId = Guid.NewGuid().ToString().Replace("-", "");
                            //if needed write the code to update the table
                            var filePath = HttpContext.Current.Server.MapPath("~/PlayerImages/" + fileId + originalFilename);
                            postedFile.SaveAs(filePath);

                            var playerinfo = dbcontext.Players.Where(p => p.Id == playerid).FirstOrDefault();
                            playerinfo.ImagePath = Convert.ToString("http://idtp285/PlayerImages/" + fileId + originalFilename);
                            dbcontext.Players.Attach(playerinfo);
                            dbcontext.Entry(playerinfo).Property(x => x.ImagePath).IsModified = true;
                            dbcontext.SaveChanges();
                        }
                    }
                    var message1 = string.Format("Image Updated Successfully.");
                    return Request.CreateErrorResponse(HttpStatusCode.Created, message1); ;
                }
                var res = string.Format("Please Upload a image.");
                dict.Add("error", res);
                return Request.CreateResponse(HttpStatusCode.NotFound, dict);
            }
            catch (Exception ex)
            {
                var res = string.Format("some Message");
                dict.Add("error", res);
                return Request.CreateResponse(HttpStatusCode.NotFound, dict);
            }
        }


        //var matches = CommanClass.GetConnection().Matches.Where(a => a.Id == id)
        //            .Select(t => new Matches
        //            {
        //                Id = t.Id,
        //                Name = t.Name,
        //                Location = t.Location,
        //                Date = t.Date,
        //                MatchPlayers = from matchess in t.MatchPlayers
        //                                join playerscoress in t.PlayerScores on matchess.PlayerId equals playerscoress.PlayerId
        //                                where matchess.PlayerId == playerscoress.PlayerId
        //                                select new FabricApplication.Models.BAL.MatchPlayer
        //                                {
        //                                    Id = matchess.Id,
        //                                    PlayerId = matchess.PlayerId,
        //                                    MatchId = matchess.MatchId,
        //                                    MatchName = matchess.Match.Name,
        //                                    FirstName = matchess.Player.FirstName,
        //                                    LastName = matchess.Player.LastName,
        //                                    PlayerImage = matchess.Player.ImagePath,
        //                                    Age = matchess.Player.Age,
        //                                    Address = matchess.Player.Address,
        //                                    PlayerRoleName = matchess.Player.PlayerRole.Name,
        //                                    Points = playerscoress.Points,
        //                                    Credits = playerscoress.Credits
        //                                }
        //            }).ToList();
    }
}
