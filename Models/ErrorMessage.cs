using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel2.Models
{
    public class ErrorMessage
    {
        public const string RequiredMsg = "{0} را وارد نمایید.";
        public const string MaxLengthMsg = "{0} نباید بیشتر از {1} کاراکتر باشد";
        public const string MinLengthMsg = "{0} نباید کمتر از {1} کاراکتر باشد";
        public const string RegExpMsg = " قالب نوشتاری {0}اشتباه است";
        public const string Comapre = "{0} پسورد وارد شده یکسان نمیباشد";
        public const string StringLengts = "باید حداقل 6 کاراکتر و حداکثر 100 کاراکتر باشد{0{1}}";

    }
}
