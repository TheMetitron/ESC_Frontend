﻿namespace Models
{
    public class Dependent
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Relationship { get; set; } = "";
    }
}
