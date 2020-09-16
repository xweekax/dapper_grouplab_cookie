using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;
using System.Web;

namespace DapperOverflow.Models
{
    [Table("Answer")]
    public class Answer
    {
        [Key]
        public long id { get; set; }
        public string Username { get; set; }
        public string Detail { get; set; }
        public long QuestionID { get; set; }
        public DateTime Posted { get; set; }
        public int Upvotes { get; set; }


        public static Answer Create(string _username, long _questionid, string _detail)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            Answer newanswer = new Answer() { Username = _username, QuestionID = _questionid, Detail = _detail };
            newanswer.Posted = DateTime.Now;
            newanswer.Upvotes = 0;
            long _id = db.Insert<Answer>(newanswer);
            newanswer.id = _id;
            return newanswer;
        }

        public static List<Answer> ReadAll()
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            List<Answer> answerlist = db.GetAll<Answer>().ToList();
            return answerlist;
        }
        public static Answer Read(long _id)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            Answer newanswer = db.Get<Answer>(_id);
            return newanswer;
        }

        public static List<Answer> GetAnswers(long _id) //Gets answers for questionID, then sort
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            List<Answer> answerlist = db.Query<Answer>($"SELECT Answer.* FROM Question JOIN Answer ON Question.id = Answer.QuestionID WHERE QuestionID={_id}").AsList();
            answerlist = answerlist.OrderByDescending(o => o.Posted).ToList();
            return answerlist;
        }

        public static Answer Update(long _id, string _username, string _detail) //Normal Edit
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            Answer newanswer = Read(_id);
            newanswer.Detail = _detail;
            newanswer.Username = _username;
            db.Update(newanswer);
            return newanswer;
        }
    }
}
