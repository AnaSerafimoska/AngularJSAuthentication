using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJSAuthentication.Controllers
{
    [RoutePrefix("api/DepartmentController")]
    public class DepartmentController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            CompanyDBEntities cb = new CompanyDBEntities();
            return Ok(cb.FetchAllDepartments());
        }
    }
}
