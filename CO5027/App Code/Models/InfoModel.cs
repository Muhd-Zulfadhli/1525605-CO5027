using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CO5027.App_Code.Models
{
    public class InfoModel
    {
        public UserInformation GetUserInformation(string guId)
        {
            meTVEntities db = new meTVEntities();
            UserInformation info = (from x in db.UserInformations
                                    where x.GUID == guId
                                    select x).FirstOrDefault();

            return info;
        }

        public void InsertUserInformation(UserInformation info)
        {
            meTVEntities db = new meTVEntities();
            db.UserInformations.Add(info);
            db.SaveChanges();
        }
    }
}