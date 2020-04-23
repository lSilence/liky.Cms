using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LikyCms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LikyCms.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }
        public IActionResult Index()
        {
            var contents = new List<Content>();
            for (int i = 1; i < 11; i++)
            {
                contents.Add(new Content { Id = i, title = i + "的标题", content = i + "的内容", status = 1, add_time = DateTime.Now.AddHours(-i * 2) });
            }
            return View(new ContentViewModel { Contents = contents });
        }
    }
}