using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pisheyar.Application.Codes.Commands.CreateCode;
using Pisheyar.Application.Codes.Commands.DeleteCode;
using Pisheyar.Application.Codes.Queries.GetCodesByCodeGroupGuid;

namespace WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeController : ApiController
    {
        /// <summary>
        /// دریافت مقادیر اولیه
        /// </summary>
        /// <param name="guid">آیدی کد گروه</param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<GetCodesByCodeGroupGuidVm>> GetCodesByCodeGroupGuid(Guid guid)
        {
            return await Mediator.Send(new GetCodesByCodeGroupGuidQuery() { CodeGroupGuid = guid });
        }

        /// <summary>
        /// افزدون کد
        /// </summary>
        /// <param name="command">اطلاعات کد</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<CreateCodeVm> Create(CreateCodeCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// حذف کد
        /// </summary>
        /// <param name="command">آیدی کد</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<DeleteCodeVm>> Delete(DeleteCodeCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
