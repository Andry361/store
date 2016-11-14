using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace Store.UI.Controllers
{
  public class AdminController : ApiController
  {
    [HttpGet]
    [ActionName("Index")]
    public HttpResponseMessage Index()
    {
      var path = HttpContext.Current.Server.MapPath("Content/admin/index.html");
      var response = new HttpResponseMessage();
      response.Content = new StringContent(File.ReadAllText(path));
      response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
      return response;
    }
  }
}
