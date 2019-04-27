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
        public object postInterview(setInterview data)
        {
            var guid = Guid.NewGuid();
            var interiew = new Interview() {

                endDate=data.etime.Date,
             //   endTime=data.etime.TimeOfDay-data.etime.TimeOfDay.Seconds,
                interviewGuid=guid,
                panelId=data.panelid,
                panelType=data.panelType,
                slotId=data.slotId,
                startDate=data.stime.Date,
                startTime=data.stime.TimeOfDay
            };

            dbContext.Interview.Add(interiew);
            return null;
        }

    }
}
