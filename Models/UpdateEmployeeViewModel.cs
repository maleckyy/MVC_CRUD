﻿namespace MVC_CRUD.Models
{
    public class UpdateEmployeeViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public long Salary { get; set; }
    }
}
