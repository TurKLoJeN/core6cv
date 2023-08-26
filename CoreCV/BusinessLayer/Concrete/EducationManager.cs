﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void TAdd(Education t)
        {
            _educationDal.Insert(t);
        }

        public void TDelete(Education t)
        {
            _educationDal.Delete(t);
        }

        public List<Education> TGetList()
        {
            return _educationDal.GetList();
        }

        public Education TGetByID(int id)
        {
            return _educationDal.GetByID(id);
        }

        public void TUpdate(Education t)
        {
            _educationDal.Update(t);
        }

        public List<Education> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}