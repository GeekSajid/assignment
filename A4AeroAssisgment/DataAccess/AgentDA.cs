using A4AeroAssisgment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace A4AeroAssisgment.DataAccess
{
    public class AgentDA
    {
        private AgentDbContext db = new AgentDbContext();

        public List<BusinessEntities> GetAllAgent()
        {
            return (db.Agents.Where(a => !a.Deleted).ToList());
        }

        public BusinessEntities GetAgentById(long id)
        {
            BusinessEntities businessentities = db.Agents.Where(a => a.BusinessId == id && !a.Deleted).FirstOrDefault();
            return businessentities;
        }

        public int Add(BusinessEntities businessentities)
        {
            db.Agents.Add(businessentities);
            int rowAffected = db.SaveChanges();
            return rowAffected;
        }

        public int Update(BusinessEntities businessentities)
        {         
            db.Entry(businessentities).State = EntityState.Modified;
            int rowAffected = db.SaveChanges();
            return rowAffected;
        }
       
    }
}