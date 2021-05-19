﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Afonsoft.NewTemplate.Services.Pages
{
    public interface IPageService
    {
        Page MainPage { get; set; }

        Task<Page> CreatePage(Type viewType, object navigationParameter);
    }
}