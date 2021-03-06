﻿using Minerva.Entities;
using Minerva.Entities.Sources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minerva.Repositories
{
    public class TagRepository : GenericFullRepository<MinervaDbContext, Tag>
    {
        private MinervaDbContext context;

        public TagRepository(MinervaDbContext context)
            : base(context)
        {
        }
    }
}
