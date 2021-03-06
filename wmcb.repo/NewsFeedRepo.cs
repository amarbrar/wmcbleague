﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmcb.model;

namespace wmcb.repo
{
    public class NewsFeedRepo
    {
        public List<NewsView> getLastestNewsFeeds(int NewsFeedCount)
        {
           List<NewsView> news = new List<NewsView>();
           using (var context = new wmcbContext())
           {
               var feeds = context.NewsFeeds
                   .Join(context.Users, nf => nf.CreatedBy, u => u.ID, (nf, u) => new { Feed = nf, User = u })
                            .OrderByDescending(n => n.Feed.CreatedOn)
                            .Select(n => new NewsView()
                            {
                                Headline = n.Feed.Headline,
                                Content = n.Feed.Content,
                                CreatedBy = n.User.FirstName,// + ' ' + n.User.LastName,
                                CreatedOn = n.Feed.CreatedOn
                            })
                            .Take(NewsFeedCount);
               if (feeds != null)
                   news = feeds.ToList();
           }
           return news;
       }
    }
}
