using System.Collections.Generic;
using Hospital.Models;

namespace Hospital.Interfaces
{
    public interface IMedicinesRepository
    {
        IEnumerable<Medicines> GetAllMedicines { get; }
        IEnumerable<Medicines> GetMedicinesOnSale { get;}
        Medicines GetMedicinesById(int medicinesId);
    }
}