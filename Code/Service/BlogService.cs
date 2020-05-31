/***********************************************************************
 * Module:  BlogService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.BlogService
 ***********************************************************************/

using Model.Surveys;
using System;
using System.Collections.Generic;

namespace Service
{
   public class BlogService : IBlogService
   {
      public BlogService GetInstance() { return null; }

        public Blog GetBlogByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public Blog Create(Blog obj)
        {
            throw new NotImplementedException();
        }

        public Blog Edit(Blog obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Blog obj)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public Repository.IBlogRepository iBlogRepository;
   
      private static BlogService Instance;
   
   }
}