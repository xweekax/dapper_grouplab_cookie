using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;

namespace DapperOverflow.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public long id { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime Posted { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public int Status { get; set; }

        public static Question Create(string _username, string _title, string _detail)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            Question newquestion = new Question() { Username = _username, Title = _title, Detail = _detail };
            newquestion.Posted = DateTime.Now;
            newquestion.Status = 0;
            newquestion.Category = "test";
            newquestion.Tags = "test";
            long _id = db.Insert<Question>(newquestion);
            newquestion.id = _id;
            return newquestion;
        }

        public static List<Question> ReadAll()
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            List<Question> questionlist = db.GetAll<Question>().ToList();
            return questionlist;
        }
        public static Question Read(long _id)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            Question question = db.Get<Question>(_id);
            return question;
        }

        public static Question Update(long _id, string _username, string _title, string _detail) //Normal Edit
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            Question newquestion = Read(_id);
            newquestion.Detail = _detail;
            newquestion.Username = _username;
            newquestion.Title = _title;
            db.Update(newquestion);
            return newquestion;
        }
        public static Question Update(long _id, int status) //For Upvotes
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            Question newquestion = Read(_id);
            newquestion.Status = status;
            db.Update(newquestion);
            return newquestion;
        }

        public static void Delete(long _id)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            List<Answer> answerlist = Answer.GetAnswers(_id); //Get all associated answers
            foreach (Answer answer in answerlist) //Delete them too
            {
                db.Delete(answer);
            }
            db.Delete(new Question() {id = _id});
        }
        public static List<Question> Search(string search)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            List<Question> questionlist = db.Query<Question>($"SELECT id, Title, Username, Posted FROM Question WHERE Detail LIKE '%{search}%'").AsList();
            return questionlist;
        }
    }
}
