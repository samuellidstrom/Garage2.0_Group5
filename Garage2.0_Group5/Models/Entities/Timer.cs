using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Garage2._0_Group5.Models.Entities

{
    
    public class Timer
    {
        private DateTime checkTime = DateTime.Now;

        
       private DateTime timer;

        public DateTime CheckTime
        {
            get
            {
                

                return timer;
            }
            //set { myVar = value; }
        }

    }

    }

