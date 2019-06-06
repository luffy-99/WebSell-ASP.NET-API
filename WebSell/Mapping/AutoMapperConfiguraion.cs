using AutoMapper;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSell.Models;

namespace WebSell.Mapping
{
    public class AutoMapperConfiguraion : Profile
    {
        public AutoMapperConfiguraion()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<Tag, TagViewModel>();
        }
    }
}