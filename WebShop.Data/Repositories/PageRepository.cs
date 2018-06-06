﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Repositories
{
    public interface IPageRepository: IRepository<Page>
    {

    }
    public class PageRepository: RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
