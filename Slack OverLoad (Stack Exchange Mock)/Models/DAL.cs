using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Slack_OverLoad__Stack_Exchange_Mock_.Models
{
    public class DAL
    {
        public static IDbConnection myDB;
        public static string currentuser;

        public static List<Questions> GetAllQs()
        {
            return myDB.GetAll<Questions>().ToList();
        }

        public static Questions GetQById(int id)
        {
            return myDB.Get<Questions>(id);
        }

        public static void SaveEditQ(Questions aQ)
        {
            if (DAL.currentuser == aQ.username || DAL.currentuser.ToLower() == "admin")
            {
                myDB.Update(aQ);
            }

        }

        public static void AddNewQ(Questions aQ)
        {
            aQ.posted = DateTime.Now;
            myDB.Insert(aQ);
        }

        public static void DeleteQ(int id)
        {
            Questions myQ = myDB.Get<Questions>(id);
            if (DAL.currentuser == myQ.username || DAL.currentuser.ToLower() == "admin")
            {
                myDB.Delete(myQ);
            }

        }

        public static Answers AddAnswer(Answers aA)
        {
            aA.posted = DateTime.Now;
            myDB.Insert(aA);
            return aA;
        }

        public static List<Answers> GetAllAs()
        {
            return myDB.GetAll<Answers>().ToList();
        }

        public static Answers GetAById(int id)
        {
            return myDB.Get<Answers>(id);
        }

        public static void SaveEditA(Answers aA)
        {
            if (DAL.currentuser == aA.username || DAL.currentuser.ToLower() == "admin")
            {
                myDB.Update(aA);
            }
        }

        public static List<Questions> SearchQs(string aString)
        {
           return myDB.Query<Questions>($"select * from questions where detail like '{aString}%'").ToList();
        }

        public static void DeleteA(int id)
        {
            Answers myA = myDB.Get<Answers>(id);
            if (DAL.currentuser == myA.username || DAL.currentuser.ToLower() == "admin")
            {
                myDB.Delete(myA);
            }
        }

        public static List<Answers> GetAllAsWithQId(int id)
        {
            string aString = id.ToString();
            return myDB.Query<Answers>($"select * from answers where questionid = {aString}").ToList();
        }

        public static void AddUpVote(Answers aA)
        {
            aA.upvotes = aA.upvotes + 1;
            myDB.Update(aA);
        }

    }
}
