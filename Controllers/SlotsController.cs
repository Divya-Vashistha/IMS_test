using IMS_New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IMS_New.Controllers
{
    public class SlotsController : ApiController
    {
        InterviewController interview = new InterviewController();

        public ApplicationDbContext dbContext;
        public SlotsController()
        {
            dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        [Route("api/slots/PostSlots")]
        public object PostSlots(Slots getSlots)
        {
            return null;
        }
    }
}
