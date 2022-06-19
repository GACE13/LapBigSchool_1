using LapBigSchool_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LapBigSchool_1.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        public List<Category> Categories { get; internal set; }
        public string Date { get; internal set; }
        public string Time { get; internal set; }
        public byte Category { get; internal set; }
        public string Place { get; internal set; }
    }
}