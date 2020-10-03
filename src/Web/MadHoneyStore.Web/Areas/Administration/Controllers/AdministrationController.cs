namespace MadHoneyStore.Web.Areas.Administration.Controllers
{
    using MadHoneyStore.Common;
    using MadHoneyStore.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
