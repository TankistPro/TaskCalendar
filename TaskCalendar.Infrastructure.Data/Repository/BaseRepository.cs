using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskCalendar.Domain.Interfaces;
using TaskCalendar.Infrastructure.Data.Context;

namespace TaskCalendar.Infrastructure.Data.Repository
{
    public class BaseRepository
    {
        private DataBaseContext _db;

        public BaseRepository(DataBaseContext context)
        {
            _db = context;
        }
    }
}
