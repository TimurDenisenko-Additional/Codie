using System.Collections.Generic;

namespace Codie.Models.DB
{
    public class DBContext
    {
        public static List<AccountModel> Accounts = new List<AccountModel>
        {
            new AccountModel
            {
            Id = 0,
            FirstName = "Admin",
            LastName = "Admin",
            Gender = "Male",
            Email = "admin@gmail.com",
            Password = "admin",
            Role = "Admin"
            }
        };

        public static List<Codie.Models.SingleChoiseModel> SingleChoiseModels = SingleChoiseData.singleData;

        public static List<Codie.Models.MultiChoiseModel> MultiChoiseModels = MultiChoiseData.multiData;

        public static List<Codie.Models.CodeTaskModel> CodeTaskModels = CodeTasksData.codeData;
    }
}