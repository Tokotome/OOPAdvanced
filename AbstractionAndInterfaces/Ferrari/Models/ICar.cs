﻿
namespace Ferrari.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface ICar
    {
        string Driver { get; }

        string Brakes();

        string Gas();

    }
}
