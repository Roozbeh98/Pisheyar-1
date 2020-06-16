using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pisheyar.Application.Discounts.Commands.CreatePublicDiscount;

namespace WebUI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ApiController
    {
        /// <summary>
        /// افزودن کد تخفیف عمومی
        /// </summary>
        /// <param name="command">اطلاعات کد تخفیف عمومی</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<CreatePublicDiscountVm>> CreatePublicDiscount(CreatePublicDiscountCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
