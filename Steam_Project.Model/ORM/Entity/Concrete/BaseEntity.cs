using Steam_Project.Model.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Model.ORM.Entity.Concrete
{
    public class BaseEntity:ICore
    {
        public int ID { get; set; }


        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate
        { 
            get { return _addDate; }
            set { _addDate = value; } 
        }



        public DateTime? UpdateDate { get ; set; }
        public DateTime? DeleteDate { get; set ; }




        private Status _status = Status.Active;
        public Status Status 
        { 
            get { return _status; }
            set { _status = value; }
        }

        
    }
}
