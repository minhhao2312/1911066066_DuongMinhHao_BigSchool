using _1911066066_DuongMinhHao_BigSchool.ViewModels;
using _1911066066_DuongMinhHao_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace _1911066066_DuongMinhHao_BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public String Place { get; set; }
        public String Date { get; set; }
        public String Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable <Category> Categories { get; set; }

        public DateTime GetDateTime ()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
        //lỗi ở format date

    }
}