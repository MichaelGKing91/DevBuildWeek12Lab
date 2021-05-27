using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Slack_OverLoad__Stack_Exchange_Mock_.Models;
using Dapper;

namespace Slack_OverLoad__Stack_Exchange_Mock_.Controllers
{
    public class QandAController : Controller
    {
        public IActionResult Index()
        {
            //if (DAL.currentuser == null)
            //{
            //    Redirect("/home/index");
            //}
            List<Questions> allQs = DAL.GetAllQs();
            return View(allQs);
        }
        public IActionResult EditForm(int id)
        {

            Questions aQ = DAL.GetQById(id);
            return View(aQ);
        }
        [HttpPost]
        public IActionResult Edit(Questions aQ)
        {
            DAL.SaveEditQ(aQ);
            return RedirectToAction("Index");
        }

        public IActionResult AddForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Questions aQ)
        {
            DAL.AddNewQ(aQ);
            return RedirectToAction("Index");
        }
        public IActionResult QuestionDelete(int id)
        {
            Questions aQ = DAL.GetQById(id);
            return View(aQ);
        }

        public IActionResult Delete(int id)
        {
            DAL.DeleteQ(id);
            return RedirectToAction("Index");
        }

        public IActionResult AnswerForm(int id)
        {
            Questions aQ = DAL.GetQById(id);
            return View(aQ);
        }

        [HttpPost]
        public IActionResult AddAnswer(Answers aA)
        {
            aA = DAL.AddAnswer(aA);
            return View(aA);
        }

        public IActionResult AnswersIndex()
        {
            List<Answers> allAs = DAL.GetAllAs();
            return View(allAs);
        }

        public IActionResult EditAnswerForm(int id)
        {
            Answers aA = DAL.GetAById(id);
            return View(aA);
        }
        [HttpPost]
        public IActionResult EditAnswer(Answers aA)
        {
            DAL.SaveEditA(aA);
            return RedirectToAction("AnswersIndex");
        }

        [HttpPost]
        public IActionResult SearchQuestion(string aString)
        {
            List<Questions> questionQuery = DAL.SearchQs(aString);
            return View(questionQuery);
        }

        public IActionResult AnswerDeleteWarning(int id)
        {
            Answers aA = DAL.GetAById(id);
            return View(aA);
        }

        public IActionResult DeleteAnswer(int id)
        {
            DAL.DeleteA(id);
            return RedirectToAction("AnswersIndex");
        }

        public IActionResult AnswersByQuestionID(int id)
        {
            List<Answers> allAsByQId = DAL.GetAllAsWithQId(id);
            Questions aQ = DAL.GetQById(id);
            ViewData["aQuestion.UserName"] = aQ.username;
            ViewData["aQuestion.Title"] = aQ.title; 
            ViewData["aQuestion.Detail"] = aQ.detail;
            ViewData["aQuestion.Posted"] = aQ.posted.ToShortDateString();
            ViewData["aQuestion.Category"] = aQ.category;
            ViewData["aQuestion.Status"] = aQ.status;
            return View(allAsByQId);
        }

        public IActionResult AddUpVote(int id)
        {
            Answers aA = DAL.GetAById(id);
            DAL.AddUpVote(aA);
            return RedirectToAction("AnswersIndex");
        }

        public IActionResult AddUpVoteToAbyQID(int id)
        {
            Answers aA = DAL.GetAById(id);
            DAL.AddUpVote(aA);
            return Redirect($"/qanda/AnswersByQuestionID/{aA.questionid}");
        }
    }
}
