using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pisheyar.Application.ChangeOrderRequestPrice.Commands.ChangeOrderRequestsPrice;
using Pisheyar.Application.ChangeOrderRequestPrice.Commands.ChangeUsersInitialCredit;
using Pisheyar.Application.Codes.Queries.GetOrderRequestsPrice;
using Pisheyar.Application.Codes.Queries.GetUsersInitialCredit;

namespace WebUI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : ApiController
    {
        /// <summary>
        /// دریافت فی هر سفارش
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<GetOrderRequestsPriceVm>> GetOrderRequestsPrice()
        {
            return await Mediator.Send(new GetOrderRequestsPriceQuery());
        }

        /// <summary>
        /// دریافت مقدار شارژ اولیه حساب ها
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<GetUsersInitialCreditVm>> GetUsersInitialCredit()
        {
            return await Mediator.Send(new GetUsersInitialCreditQuery());
        }

        /// <summary>
        /// تغییر فی هر سفارش
        /// </summary>
        /// <param name="command">اطلاعات لازم</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<ChangeOrderRequestsPriceVm>> ChangeOrderRequestsPrice(ChangeOrderRequestsPriceCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// تغییر شارژ اولیه حساب ها
        /// </summary>
        /// <param name="command">اطلاعات لازم</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<ChangeUsersInitialCreditVm>> ChangeUsersInitialCredit(ChangeUsersInitialCreditCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
