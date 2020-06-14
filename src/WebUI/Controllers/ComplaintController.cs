using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pisheyar.Application.Contact.Commands.CreateComplaint;
using Pisheyar.Application.Posts.Queries.GetAllComplaints;

namespace WebUI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintController : ApiController
    {
        /// <summary>
        /// ارسال شکایت
        /// </summary>
        /// <param name="command">اطلاعات شکایت</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<CreateComplaintVm> Create(CreateComplaintCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// دریافت تمامی شکایات
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<GetAllComplaintsVm>> GetAll()
        {
            return await Mediator.Send(new GetAllComplaintsQuery());
        }
    }
}
