using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebShop.DAL;
using WebShop.Model;

namespace WebShop.Web.Services
{
    public class IsUserAdminService
    {
        private readonly WebShopDbContext _dbContext;
        private readonly IHttpContextAccessor _accessor;
        private UserManager<AppUser> _userManager;

        public IsUserAdminService(WebShopDbContext dbContext, UserManager<AppUser> userManager, IHttpContextAccessor accessor)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _accessor = accessor;
        }

        public async Task<bool> IsAdmin() {
            string email = (_accessor?.HttpContext?.User as ClaimsPrincipal).Identity.Name;

            if (email == null) {
                return false;
            }

            AppUser user = await _userManager.FindByNameAsync(email);
            bool admin = await _userManager.IsInRoleAsync(user, "Admin");

            return admin;
        }
    }
}
