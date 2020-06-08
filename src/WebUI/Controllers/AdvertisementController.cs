using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pisheyar.Application.Advertisements.Commands.CreateAdvertisement;
using Pisheyar.Application.Posts.Queries.GetAllAdvertisements;

namespace WebUI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementController : ApiController
    {
        /// <summary>
        /// افزودن تبلیغ جدید
        /// </summary>
        /// <param name="command">اطلاعات تبلیغ</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<CreateAdvertisementVm>> Create(CreateAdvertisementCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// دریافت تمامی تبلیغ ها
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<GetAllAdvertisementsVm>> GetAll()
        {
            return await Mediator.Send(new GetAllAdvertisementsQuery());
        }
    }
}