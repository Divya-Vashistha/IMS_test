using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IMS_New.Models;

namespace IMS_New.Controllers
{
    public class InterviewController : ApiController
    {
        public ApplicationDbContext dbContext;
        public InterviewController()
        {
            dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        [Route("api/interview/PostInterview")]
        public object postInterview(Interview data)
        {
            data.interviewGuid = Guid.NewGuid();
            dbContext.Interview.Add(data);
            dbContext.SaveChanges();

            
            var exception = new SlotException() {
            end=data.end,
            start=data.start,
            slotId=data.slotId,
            status="booked"
            };
            return null;
        }
       

    }
}
