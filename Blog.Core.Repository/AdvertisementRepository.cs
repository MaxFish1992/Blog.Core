﻿using Blog.Core.IRepository;
using Blog.Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Core.Repository
{
    public class AdvertisementRepository : IAdvertisementRepository
    {
        public int Sum(int i, int j)
        {
            return i + j;
        }

        public int Add(Advertisement model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Advertisement model)
        {
            throw new NotImplementedException();
        }

        public List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression)
        {
            throw new NotImplementedException();
        }

        public bool Update(Advertisement model)
        {
            throw new NotImplementedException();
        }
    }
}
