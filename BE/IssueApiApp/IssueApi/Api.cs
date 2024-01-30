using DataAccess.Models;

namespace BE_upg1
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app) 
        {
            app.MapGet("/issues", GetIssues);
            app.MapPost("/issues", InsertIssue);
        }

        private static async Task<IResult> GetIssues(IIssueData data)
        {
            try
            {
                return Results.Ok(await data.GetIssues());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);                
            }
        }

        private static async Task<IResult> InsertIssue(IssueModel issue, IIssueData data)
        {
            try
            {
                await data.InsertIssue(issue);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
    }
}
