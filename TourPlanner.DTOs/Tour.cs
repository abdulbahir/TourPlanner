using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourPlanner.DTOs
{
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string TransportType { get; set; }

        public Tour()
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.From = From;
            this.To = To;
            this.TransportType = TransportType;

        }
    }
}
