using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Contracts
{
    public class MenuResponse
    {
        public Guid Id { get; set; }
        public AverageRating AverageRating { get; set; }

    }
}
