﻿using System.Collections.Generic;
using System.Linq;
using Academy2018_.NET_Homework5.Infrastructure.Abstractions;
using Academy2018_.NET_Homework5.Infrastructure.Database;
using Academy2018_.NET_Homework5.Infrastructure.Models;
using Academy2018_.NET_Homework5.Infrastructure.Repositories.Basic;

namespace Academy2018_.NET_Homework5.Infrastructure.Repositories
{
    public class TicketsRepository: BasicRepository<Ticket>
    {
        public TicketsRepository(AirportContext ctx) : base(ctx)
        {
        }
    }
}
