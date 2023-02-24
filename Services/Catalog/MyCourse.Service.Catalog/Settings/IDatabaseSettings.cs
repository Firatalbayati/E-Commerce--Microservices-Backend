﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Service.Catalog.Settings
{
    public interface IDatabaseSettings
    {
        public string CourseCollectionName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatebaseName { get; set; }
    }
}
