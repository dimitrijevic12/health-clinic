/***********************************************************************
 * Module:  IBlogRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IBlogRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IBlogRepository : IRepository
   {
      Model.Surveys.Blog GetBlog(String title);
   }
}