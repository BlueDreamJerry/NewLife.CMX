﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewLife.Cube;
using XCode;

namespace NewLife.CMX.Web.Controllers
{
    public class ArticleController : TitleController<Article>
    {
        static ArticleController()
        {
            // 过滤掉一些字段
            var list = ListFields;
            list.RemoveAll(e => e.Name.EqualIgnoreCase(Article._.Cover));
        }
    }

    public class ArticleCategoryController : CategoryController<ArticleCategory> { }

    //public class ArticleContentController : ContentController<ArticleContent> { }

    //public class ArticleStatisticsController : StatisticsController<ArticleStatistics> { }

}