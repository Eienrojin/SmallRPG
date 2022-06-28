using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    internal interface IHaveHealth
    {
        int GetDamage(int damage);
        bool Dead();
    }
}
