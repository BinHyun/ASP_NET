using System;
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
        public ActionResult List()
        {
            DocumentActs documentActs = new DocumentActs();
            MemberActs memberActs = new MemberActs();

            var documents = documentActs.GetDocuments();
            var member = memberActs.GetMember(1);

            //ViewBag.Member = member;
            ViewData["Member"] = member;

            return View(documents);
        }
    }
}