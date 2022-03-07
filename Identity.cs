using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class Identity
    {
        //These are the fields that the will be will be within the database, they will be automatically be taken care by the mongodb bson
        public string strName { get; set; }
        public string strSurname { get; set; }
        public string str_ID { get; set; }
        public string strDate { get; set; }

    }
}
