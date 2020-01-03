using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dtos
{
  public  class OwnersDtoIn
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset BirthDay { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string RFC { set; get; }
    }
}
