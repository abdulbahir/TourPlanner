using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourPlanner.Models
{
    public class Tour
    {
        /*
        public string Name { get; set; }
        */

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _from;

        public string From
        {
            get { return _from; }
            set { _from = value; }
        }

        private string _to;

        public string To
        {
            get { return _to; }
            set { _to = value; }
        }

        private string _transportType;

        public string TransportType
        {
            get { return _transportType; }
            set { _transportType = value; }
        }

        private string _tourDistance;

        public string TourDistance
        {
            get { return _tourDistance; }
            set { _tourDistance = value; }
        }

        private string _estimatedTime;

        public string EstimatedTime
        {
            get { return _estimatedTime; }
            set { _estimatedTime = value; }
        }

        private string _routeInformation;

        public string RouteInformation
        {
            get { return _routeInformation; }
            set { _routeInformation = value; }
        }

        public Tour(string name, string description, string from, string to, string transportType)
        {
            this.Name = name;
            this.Description = description;
            this.From = from;
            this.To = to;
            this.TransportType = transportType;

        }
    }
}
