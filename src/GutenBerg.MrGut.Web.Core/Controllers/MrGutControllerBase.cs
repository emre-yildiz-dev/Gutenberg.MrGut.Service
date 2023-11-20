using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GutenBerg.MrGut.Controllers
{
    public abstract class MrGutControllerBase: AbpController
    {
        protected MrGutControllerBase()
        {
            LocalizationSourceName = MrGutConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
