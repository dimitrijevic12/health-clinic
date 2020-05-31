/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Surveys;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class BlogRepository : IBlogRepository
   {
      public BlogRepository GetInstance() { return null; }

        public Blog GetBlog(string title)
        {
            throw new NotImplementedException();
        }

        public Blog Save(Blog obj)
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

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        private String Path;
      private static BlogRepository Instance;
   
   }
}