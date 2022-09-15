using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edsm.Sdk.Dto
{
    public interface IEdsmRequest
    {
        Uri Path { get; }

        Type ResponseType { get; }
    }
}
