using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Descrpition { get; set; }

        public List<Staff> Staffs { get; set;}
    }
}
