using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dtos
{
    public class OwnersDto
    {
        public Guid Id { set; get;}
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string RFC { get; set; }

    }
}
