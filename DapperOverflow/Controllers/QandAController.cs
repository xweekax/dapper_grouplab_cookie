using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DapperOverflow.Models;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;


namespace DapperOverflow.Controllers
{
    public class QandAController : Controller
    {

        //GENERAL ####################################################################################
        [HttpPost]
        public IActionResult Index(string activeUser) //Displays ALL question
        {
            HttpContext.Response.Cookies.Append("activeUser", activeUser);
            ViewBag.activeUser = activeUser;
            
            List<Question> list = Question.ReadAll();            
            return View(list);
        }
        [HttpPost]
        public IActionResult Index(List<Question> list)
        {
            ViewBag.activeUser = HttpContext.Request.Cookies["activeUser"];

            return View(list);
        }
        public IActionResult Index() //Displays ALL question
        {

            ViewBag.activeUser = HttpContext.Request.Cookies["activeUser"];

            List<Question> list = Question.ReadAll();
            return View(list);
        }

        public IActionResult Detail(long _id)
        {
            Question question = Question.Read(_id);
            ViewBag.activeUser = HttpContext.Request.Cookies["activeUser"];
            ViewBag.Answerlist = Answer.GetAnswers(_id);
            return View(question);
        }

        //QUESTIONS #####################################################################################################
        public IActionResult Add() //General "blank" ADD view
        {
            ViewBag.activeUser = HttpContext.Request.Cookies["activeUser"];
            return View();
        }
        [HttpPost]
        public IActionResult Add(string username, string title, string detail) //Create new question
        {
            if (username == null || title == null || detail == null)
            {
                ViewBag.Message = "FIELDS CANNOT BE BLANK";
                ViewBag.activeUser = HttpContext.Request.Cookies["activeUser"];
                return View();
            }
            else
            {
                ViewBag.activeUser = HttpContext.Request.Cookies["activeUser"];
                Question newquestion = Question.Create(username, title, detail);
                return View("Index");
            }
            
        }

        public IActionResult Close(long _id, int status) //Closes Question
        {
            Question.Update(_id, status);
            return RedirectToAction("Index");
        }

        public IActionResult Search(string search) //Searches based on input
        {
            List<Question> questionlist = Question.Search(search);
            int results = questionlist.Count();
            ViewBag.Searchresult = $"Search Results for \"{search}\" - {results}";
            return View("Index", questionlist);
        }

        public IActionResult Edit(long _id) //Shows pre-populated add view
        {
            Question question = Question.Read(_id);
            return View(question);
        }

        public IActionResult Save(long _id, string username, string title, string detail)
        {
            username = HttpContext.Request.Cookies["activeUser"];

            if (username == null || title == null || detail == null)
            {
                Question question = Question.Read(_id);
                ViewBag.activeUser = HttpContext.Request.Cookies["activeUser"];
                ViewBag.Message = "FIELDS CANNOT BE BLANK";
                return View("Edit", question);
            }

            ViewBag.activeUser = HttpContext.Request.Cookies["activeUser"];

            Question.Update(_id, username, title, detail);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(long _id)
        {
            Question.Delete(_id);
            return RedirectToAction("Index");
        }

        //ANSWERS ##########################################################################################
        public IActionResult GetAnswer(long _id) //Gets specific answer based on ID
        {
            Answer newanswer = Answer.Read(_id);
            ViewBag.activeUser = HttpContext.Request.Cookies["activeUser"];
            return View("AddAnswer", newanswer);
        }

        public IActionResult AddAnswer(long _id) //With QuestionID
        {
            ViewBag.QuestionID = _id;
            return View();
        }

        [HttpPost]
        public IActionResult EditAnswer(Answer answer)
        {
            return View("AddAnswer", answer);
        }

        [HttpPost]
        public IActionResult AnsSave(long _id, long _questionid, string username, string detail)
        {
            if (username == null || detail == null)
            {
                ViewBag.Message = "FIELDS CANNOT BE BLANK";
                ViewBag.QuestionID = _questionid;
                return View("AddAnswer");
            }
            else
            {
                Answer newanswer;
                if (_id == 0)
                {
                    newanswer = Answer.Create(username, _questionid, detail);
                }
                else
                {
                    newanswer = Answer.Update(_id, username, detail);
                }
                return RedirectToAction("Index");
            }
        }

        
    }
}
