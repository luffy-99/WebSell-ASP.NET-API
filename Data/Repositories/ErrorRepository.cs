﻿using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {

    }
    public class ErrorRepository : RepositoryBase<Error>,IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
