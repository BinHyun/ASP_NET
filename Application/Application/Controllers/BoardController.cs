﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Data;
using Application.Models;

namespace Application.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        //매개변수 설정 시, 데이터 타입 뒤에 ? 를 붙여주면 null 허용
        public ActionResult List(int? id)
        {
            if(id == null)
                return HttpNotFound();
            
            DocumentActs documentActs = new DocumentActs();
            var documents = documentActs.GetDocuments();

            return View(documents);
        }
    }
}