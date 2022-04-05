using FluentFTP.Helpers;
using System;

namespace Delegete__.Models
{
    internal class User : IEntity
    {

        public string UserName { get; set; }
        public string Email { get; set; }

        public int Id => throw new NotImplementedException();

        //    private Enums enums;

        //    public Roler Roler
        //    {
        //        get { return _roler; }
        //        set { _roler= value; }
        //    }
        //}
    }
}