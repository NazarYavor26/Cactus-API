using Cactus_API.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus_API.BLL.Services
{
    public interface IHelpCallService
    {
        HelpCallModel AddHelpCallData(HelpCallModel helpCallModel);
    }
}
