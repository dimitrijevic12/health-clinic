/***********************************************************************
 * Module:  BlogService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.BlogService
 ***********************************************************************/

using Model.Surveys;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class BlogController : IBlogController
   {
        public BlogController GetInstance(){ return null; }
        public Blog GetBlogByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(Blog obj)
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

        public Service.IBlogService iBlogService;
   
      private static BlogController Instance;
   
   }
}