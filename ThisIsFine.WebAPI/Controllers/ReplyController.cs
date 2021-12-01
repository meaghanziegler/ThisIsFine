using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThisIsFine.Models;
using ThisIsFine.Services;

namespace ThisIsFine.WebAPI.Controllers
{
    [Authorize]
    public class ReplyController : ApiController
    {
        private ReplyService CreateReplyService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var replyService = new ReplyService(userId);
            return replyService;
        }
        public IHttpActionResult Get()
        {
            ReplyService replyService = CreateReplyService();
            var replies = replyService.GetReplies();
            return Ok(replies);
        }
        public IHttpActionResult Create(ReplyCreate reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.CreateReply(reply))
                return InternalServerError();

            return Ok();
        }
    }
}
