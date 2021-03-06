﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Web.Models.DataAccessPostgreSqlProvider;

namespace Adaptive_application_Web.Controllers
{
    public class UploadController : Controller
    {
        //public static string ToStringJury(List<string> juri)
        //{

        //    string stroka = "";
        //    foreach (var e in juri)
        //    {
        //        stroka = stroka + e;
        //        stroka += ", ";
        //    }

        //    return stroka;
        //}

        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoUpload(IFormFile file)
        {
            using (var stream = file.OpenReadStream())
            {
                var xs = new XmlSerializer(typeof(Adaptive_educational_application.Adaptive_educational_application));
                var application = (Adaptive_educational_application.Adaptive_educational_application)xs.Deserialize(stream);


                using (var db = new AdaptiveApplicationDbContext())
                {
                    var dbs = new DBAdaptive_educational_application()
                    {
                        UserName = application.UserName,
                        User_Picture = application.User_Picture,
                        Traffic_Laws_Level = application.Traffic_Laws_Level,
                        Algebra_Level = application.Algebra_Level,
                        Geometry_Level = application.Geometry_Level,
                        Music_Level = application.Music_Level,
                        Curent_Level_User = application.Curent_Level_User,
                        //Curent_User_Level = application.Curent_User_Level
                    };
                    dbs.Journal = new Collection<DbSuggestion_for_improvements>();
                    foreach (var suggestion in application.Journal)
                    {
                        dbs.Journal.Add(new DbSuggestion_for_improvements()
                        {
                            Subject_Area = suggestion.Subject_Area,
                            Wishes = suggestion.Wishes,
                            Proposed_link = suggestion.Proposed_link,
                            Add_to_application = suggestion.Add_to_application
                        });
                    }

                    db.Adaptive.Add(dbs);
                    db.SaveChanges();
                }
                return View(application);
            }
        }

        //public ActionResult Image(int id)
        //{
        //    using (var db = new AdaptiveApplicationDbContext())
        //    {
        //        return base.File(db.DUser.Find(id).User_Picture, "image/jpeg");
        //    }
        //}

        public ActionResult List()
        {
            List<DBAdaptive_educational_application> list;
            using (var db = new AdaptiveApplicationDbContext())
            {
                list = db.Adaptive.Include(s => s.Journal).ToList();
            }

            return View(list);
        }
    }
}