﻿using AutoMapper;
using CoreWiki.Application.Articles.Reading;
using Xunit;

namespace CoreWiki.Test.Application.Reading
{
	public class ArticleReadingProfileTests
	{
		private readonly IMapper _mapper;
		private readonly MapperConfiguration _mapperConfiguration;

		public ArticleReadingProfileTests()
		{
			_mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<ArticleReadingProfile>());
			_mapper = _mapperConfiguration.CreateMapper();
		}

		[Fact]
		public void ConfigTest()
		{
			_mapperConfiguration.AssertConfigurationIsValid();
		}
	}
}
