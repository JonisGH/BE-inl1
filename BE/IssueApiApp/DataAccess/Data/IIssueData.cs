using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IIssueData
    {
        Task<IEnumerable<IssueModel>> GetIssues();
        Task InsertIssue(IssueModel issue);
    }
}