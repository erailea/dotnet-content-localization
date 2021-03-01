﻿


using System.Collections.Generic;
using AspNetCoreContentLocalization.Data.Entities;

namespace AspNetCoreContentLocalization.Data.Repositories.Abstractions
{
  public interface ILocalizedBookRepository
  {
    IEnumerable<LocalizedBook> GetAll(string cultureCode);
  }
}