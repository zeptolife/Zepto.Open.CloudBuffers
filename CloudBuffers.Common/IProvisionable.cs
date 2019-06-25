using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CloudBuffers.Common
{
    public interface IProvisionable
    {
        Task<bool> Provision();

        bool IsProvisioned();

        X50

    }
}
