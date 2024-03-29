﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        List<Category> GetCategories();
        void Add(Category category);

        void Delete(Category category);

        void Update(Category category);
    }
}
