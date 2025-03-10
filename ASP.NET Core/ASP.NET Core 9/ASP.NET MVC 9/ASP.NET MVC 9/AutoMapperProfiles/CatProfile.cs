﻿using ASP.NET_MVC_9.Data.Entity;
using ASP.NET_MVC_9.Models.DTO;
using AutoMapper;

namespace ASP.NET_MVC_9.AutoMapperProfiles
{
	public class CatProfile : Profile
	{
		public CatProfile()
		{
			CreateMap<Cat, CatDTO>().ReverseMap();
		}
	}
}
