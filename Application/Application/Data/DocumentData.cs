using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Models;

namespace Application.Data
{
    public class DocumentData
    {
        public List<Document> Documents 
        { 
            get
            {
                List<Document> returnValue = new List<Document>
                {
                    new Document() {Document_Number = 1, Title = "공지사항 입니다.", Writer = "김빈현" },
                    new Document() {Document_Number = 2, Title = "2번 글 입니다.", Writer = "김빈현" },
                    new Document() {Document_Number = 3, Title = "3번 글 입니다.", Writer = "김빈현" },
                    new Document() {Document_Number = 4, Title = "4번 글 입니다.", Writer = "김빈현" },
                    new Document() {Document_Number = 5, Title = "5번 글 입니다.", Writer = "김빈현" }

                };

                return returnValue;
            } 
            
        }

    }

    public class BearData
    {
        public List<Bear> Bears
        {
            get
            {
                List<Bear> returnBearInfo = new List<Bear>
                {
                    new Bear() { BearId = 1, BearColor = "gray", BearName = "grayBear" }
                };

                return returnBearInfo;
            }

        }
    }
}