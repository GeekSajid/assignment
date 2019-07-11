using A4AeroAssisgment.DataAccess;
using A4AeroAssisgment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A4AeroAssisgment.BusinessLogic
{
    public class AgentBL
    {
        private AgentDA agentDA = new AgentDA();

        public List<BusinessEntities> AgentList()
        {
            return (agentDA.GetAllAgent());
        }

        public BusinessEntities GetAgentById(long id)
        {
            BusinessEntities businessentities = agentDA.GetAgentById(id);
            return businessentities;
        }

        public string Add(BusinessEntities businessentities)
        {
            businessentities.CreatedOnUtc = DateTime.Now;
            int rowAffected = agentDA.Add(businessentities);
            if (rowAffected > 0)
            {
                return "Save Successfull";
            }
            return "Save Failed";
        }

        public string Update(BusinessEntities businessentities)
        {
            businessentities.UpdatedOnUtc = DateTime.Now;
            int rowAffected = agentDA.Update(businessentities);
            if (rowAffected > 0)
            {
                return "Update Successfull";
            }
            return "Update Failed";
        }

        public string SoftDelete(BusinessEntities businessentities)
        {
            businessentities.Deleted = true; 
            int rowAffected = agentDA.Update(businessentities);
            if (rowAffected > 0)
            {
                return "Delete Successfull";
            }
            return "";
        }
    }
}