using AutoMapper;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
            CreateMap<Article, ArticleUpdateDto>().ReverseMap();
            CreateMap<ArticleUpdateDto, ArticleDto>().ReverseMap();
        }
    }
}
