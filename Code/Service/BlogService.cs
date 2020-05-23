/***********************************************************************
 * Module:  BlogService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.BlogService
 ***********************************************************************/

using Model.Surveys;
using System;

namespace Service
{
   public class BlogService : IBlogService
   {
      public Repository.BlogRepository blogRepository;

        public Blog Create(Blog obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Blog obj)
        {
            throw new NotImplementedException();
        }

        public Blog Edit(Blog obj)
        {
            throw new NotImplementedException();
        }

        public Blog[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Blog GetBlogByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}