using Blog.Core.IRepository;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Repository;
using Blog.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Core.Services
{
    public class AdvertisementServices : BaseServices<Advertisement>, IAdvertisementServices
    {
        //IAdvertisementRepository dal = new AdvertisementRepository();

        //public int Add(Advertisement model)
        //{
        //    return 1;
        //}

        //public bool Delete(Advertisement model)
        //{
        //    return false;
        //}

        //public List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression)
        //{
        //    return null;
        //}

        //public int Sum(int i, int j)
        //{
        //    return 1;
        //}

        //public bool Update(Advertisement model)
        //{
        //    return false;
        //}
    }
}
