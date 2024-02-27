using Bookshelf.DATA.Interfaces;
using Bookshelf.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshelf.DATA.Repositories
{
    public class RepositoryCustomer : RepositoryBase<Customer>, IRepositoryCustomer
    {
        public RepositoryCustomer(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}
