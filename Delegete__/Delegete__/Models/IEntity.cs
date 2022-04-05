using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegete__.Models
{
    internal interface IEntity
    {/*Bu interface-i implement edən class-larda id dəyəri avtomatik artacaq və qıraqdan set etmək olmaz yalnız get etmək olar.*/
        private static int _id;
        public int Id { get;  }
        void IEntity()
        {
            _id++;
            _id = Id;
        }
        
    }
}
