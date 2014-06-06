﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Minerva.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Minerva.ApiControllers
{
    [Authorize]
    [EnableCors(origins: "http://10.5.100.178/Minerva,http://192.168.0.10/Minerva", headers: "*", methods: "*")]
    public class AccountController : ApiController
    {
        private UserManager<ApplicationUser> _userManager;
        public AccountController()
        {
            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new MinervaDbContext()));
        }

        [AllowAnonymous]
        public async Task<IHttpActionResult> Login(LoginBindingModel model)
        {
            return Ok();
            /*if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }*/
            /*
            var user = await _userManager.FindAsync(model.Username, model.Password);
            if (user != null)
            {
                //await SignInAsync(user, model.RememberMe);
                return Ok();
            }

            return NotFound();*/
        }
        /*
        public async Task<IHttpActionResult> Register()
        {
            return BadRequest();
        }

        private Task<IHttpActionResult> SignInAsync(ApplicationUser user, bool? nullable)
        {
            throw new NotImplementedException();
        }
        */
        private Task SignInAsync(ApplicationUser user, bool isPersistent)
        {
            return null;
        }
    }
}