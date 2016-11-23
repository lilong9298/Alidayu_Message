using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alidayu_Message {
    public interface IAlidayu_Manage {
        Task SendMessage(object model);
    }
}
