using MVC_Demo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public interface IStoreModels<T>
    {
        List<T> GetList();
    }
}