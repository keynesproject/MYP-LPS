using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MypKey
{
    public enum ValidateResult
    {
        eVALIDATE_SUCCESS,
        eVALIDATE_NO_SN,
        eVALIDATE_SN_INVALID,
        eVALIDATE_NOT_RIGHT_MACHINE,
        eVALIDATE_EXPIRED
    }
}
