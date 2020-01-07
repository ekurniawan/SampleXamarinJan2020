using System;
using System.Collections.Generic;
using System.Text;

namespace SampleMobileXam.Models
{
    public abstract class JsonStatus<T>
    {
        public int statusCode { get; set; }
        public string message { get; set; }
        public bool isError { get; set; }
        public List<T> result { get; set; }
    }
}
