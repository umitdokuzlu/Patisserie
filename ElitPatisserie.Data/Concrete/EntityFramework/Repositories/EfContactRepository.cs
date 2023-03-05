﻿using ElitPatisserie.Data.Abstract;
using ElitPatisserie.Data.Concrete.EntityFramework.Contexts;
using ElitPatisserie.Data.Concrete.EntityFramework.GenericRepository;
using ElitPatisserie.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElitPatisserie.Data.Concrete.EntityFramework.Repositories
{
    public class EfContactRepository : GenericDal<Contact>, IContactRepository
    {
        public EfContactRepository(ElitPatisserieContext context) : base(context)
        {
        }
    }
}
