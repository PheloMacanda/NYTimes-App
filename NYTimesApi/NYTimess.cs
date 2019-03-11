using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NYTimesApi
{
    
    [ServiceContract]
    public interface NYTimess{
        
        // This is an interface that defines all the book attributes in the book API
        
        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public double Price { get; set; }
    }
}
