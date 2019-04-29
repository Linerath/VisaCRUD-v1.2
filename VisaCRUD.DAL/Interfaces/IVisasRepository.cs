﻿using System.Collections.Generic;
using VisaCRUD.DAL.Entities;

namespace VisaCRUD.DAL.Interfaces
{
    public interface IVisasRepository
    {
        List<Visa> GetAll();
        int Add(Visa visa);
        bool Add(List<Visa> visa);
        bool Update(Visa visa, int? id = null);
        void Delete(Visa visa);
        void Delete(int id);

        List<Country> GetAllCountries();
        Visa GetVisaByCountryId(int id);
    }
}
