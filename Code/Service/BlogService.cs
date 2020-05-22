/***********************************************************************
 * Module:  BlogService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.BlogService
 ***********************************************************************/

using System;

namespace Service
{
   public class BlogService : IBlogService
   {
      public Repository.BlogRepository blogRepository;
   
   }
}