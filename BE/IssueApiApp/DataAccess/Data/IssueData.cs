using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class IssueData : IIssueData
    {
        private readonly ISqlDataAccess _db;

        public IssueData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<IssueModel>> GetIssues() =>
            _db.LoadData<IssueModel, dynamic>("dbo.spIssue_GetAll", new { });

        public Task InsertIssue(IssueModel issue) =>
            _db.SaveData("dbo.spIssue_Insert", new
            {
                Header = issue.Header,
                Comment = issue.Comment,
                Status = issue.Status,
                Email = issue.Email,
                Datetime = issue.Datetime
            });
    }

}
