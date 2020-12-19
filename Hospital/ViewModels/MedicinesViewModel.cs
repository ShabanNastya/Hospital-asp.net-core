using System.Collections.Generic;
using Hospital.Models;

namespace Hospital.ViewModels
{
    public class MedicinesViewModel
    {
        public IEnumerable<Medicines> Medicineses { get; set; }
        
        //
        public string CurrentCategory { get; set; }
    
    }
}