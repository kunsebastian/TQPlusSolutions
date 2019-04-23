using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using TQPlusSolutionsDM.Helpers;
using TQPlusSolutionsDM.Models;

namespace TQPlusSolutionsDM.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        private List<cm_employeelist> Employee = new List<cm_employeelist>()
        {
            new cm_employeelist {id = 1, firstname = "Rick", lastname = "Ross", yearsOfExperience = 9},
            new cm_employeelist {id = 2, firstname = "Matt", lastname = "Barnes", yearsOfExperience = 19},
            new cm_employeelist {id = 3, firstname = "Grant", lastname = "Hill", yearsOfExperience = 4},
            new cm_employeelist {id = 4, firstname = "Michael", lastname = "Jordan", yearsOfExperience = 22},
        };
        
        public IHttpActionResult Get()
        {
            return Ok(Employee); 
        }


        public IHttpActionResult Get(int id)
        {
             var result = Employee.Where(x => x.id == id);

            try
            {
                if (result != null)
                {
                    return Ok(result);
                }
                return Ok(new JsonMessages<string>()
                {
                    Success = false,
                    ErrorMessage = "Record not found"
                });
            }
            catch (Exception ex)
            {
                return Ok(new JsonMessages<string>()
                {
                    Success = false,
                    ErrorMessage = ex.Message
                });

            }


        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
