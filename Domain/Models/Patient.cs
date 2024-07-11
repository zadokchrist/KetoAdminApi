﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile {  get; set; }
        public DateOnly DateOfBirth {  get; set; }
        public string Gender {  get; set; }
        public string WhatsappNumber {  get; set; }
        public string Email {  get; set; }
        public string Address {  get; set; }


    }
}
