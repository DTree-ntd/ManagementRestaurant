﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class Menu
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ProductId { get; set; }

        public string Description { get; set; }

    }
}
