using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTechJiraSmulation
{
    public class AccountManager
    {
        private List<Account> _accountList;
        private List<Issue> _issueListList;

        public AccountManager()
        {
            //Accounts
            this._accountList = new List<Account>();
            this._accountList.Add(new Account { Code = "T32081", Name = "Kubilay", Surname = "Kara", Password = "0" });
            this._accountList.Add(new Account { Code = "T05999", Name = "Ulaş", Surname = "Ergin", Password = "0" });

            //Issues
            this._issueListList = new List<Issue>();
            this._issueListList.Add(new Issue { Title = "OOM Inceleme", Content = "Tabletlerde OOM alan ekranları inceleyelim", AssigneeCode = "T32081", Status = IssueStatus.Inprogress, Deadline = new DateTime(2017, 6, 1) });
            this._issueListList.Add(new Issue { Title = "Style", Content = "Style dosyalarının branchapp'a taşınması", AssigneeCode = "T32081", Status = IssueStatus.Inprogress, Deadline = new DateTime(2017, 9, 10) });
            this._issueListList.Add(new Issue { Title = "Region gibi userControl", Content = "Region gibi çalışan bir user control altyapısı sağlayalım.", AssigneeCode = "T32081", Status = IssueStatus.Inprogress, Deadline = new DateTime(2017, 10, 15) });
            this._issueListList.Add(new Issue { Title = "Core Next Next Setup", Content = "Next Next ile kuralabilecek bir code ortamı ve configusarsyon DB'si", AssigneeCode = "T05999", Status = IssueStatus.Inprogress, Deadline = new DateTime(2017, 8, 20) });
            this._issueListList.Add(new Issue { Title = "2018 Hedef", Content = "Kişisel deflerin belirlenmesi.", AssigneeCode = "T05999", Status = IssueStatus.Inprogress, Deadline = new DateTime(2017, 9, 1) });

        }

        public bool Login(string userCode, string password,out Account account) 
        {
            account = this._accountList.FirstOrDefault(a => a.Code == userCode && a.Password == password.Trim());

            return account != null;
        }

        public List<Issue> GetIssues(Account a)
        {
            return this._issueListList.Where(i => i.AssigneeCode == a.Code).ToList();
        }
    }
}
