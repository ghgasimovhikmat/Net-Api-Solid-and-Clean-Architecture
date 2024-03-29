﻿using HRManagment.MVC.Contarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
namespace HRManagment.MVC.Services.Base
{
    public class BaseHttpService
    {
        protected readonly ILocalStorageService _localStorage;
        protected IClient _client;

        public BaseHttpService(ILocalStorageService localStorage, IClient iclient)
        {
            _localStorage = localStorage;
            _client = iclient;
        }
        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException ex)
        {
            if (ex.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "Validation errors have occured .", ValidationErros = ex.Response, Success = false };
            }
            else if (ex.StatusCode == 404)
            {
                return new Response<Guid>() { Message = "The requested item could not be found", Success = false };
            }
            else
            {
                return new Response<Guid>() { Message = "Something went wrong,please try again", Success = false };
            }
        }
        protected void AddBearerToken()
        {
            if (_localStorage.Exists("token"))
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _localStorage.GetStorageValue<string>("token"));
        }
    }
}
