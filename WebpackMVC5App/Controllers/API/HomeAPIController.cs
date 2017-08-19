using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebpackMVC5App.Controllers.API
{
    public class HomeAPIController : ApiController
    {
        /// <summary>
        /// Demo call just to return basic NFPA 704 data
        /// </summary>
        /// <returns>http://localhost/WebpackMVC5App/api/homeapi/getnfpadata</returns>
        public IEnumerable<Models.NFPAModel> GetNFPAData()
        {
            yield return new Models.NFPAModel() { ID = 1, Name = "0", NFPAType = Models.NFPATypeEnum.Health, Description = Models.NFPAModel.health0 };
            yield return new Models.NFPAModel() { ID = 2, Name = "1", NFPAType = Models.NFPATypeEnum.Health, Description = Models.NFPAModel.health1 };
            yield return new Models.NFPAModel() { ID = 3, Name = "2", NFPAType = Models.NFPATypeEnum.Health, Description = Models.NFPAModel.health2 };
            yield return new Models.NFPAModel() { ID = 4, Name = "3", NFPAType = Models.NFPATypeEnum.Health, Description = Models.NFPAModel.health3 };
            yield return new Models.NFPAModel() { ID = 5, Name = "4", NFPAType = Models.NFPATypeEnum.Health, Description = Models.NFPAModel.health4 };

            yield return new Models.NFPAModel() { ID = 6, Name = "0", NFPAType = Models.NFPATypeEnum.Flammability, Description = Models.NFPAModel.flam0 };
            yield return new Models.NFPAModel() { ID = 7, Name = "1", NFPAType = Models.NFPATypeEnum.Flammability, Description = Models.NFPAModel.flam1 };
            yield return new Models.NFPAModel() { ID = 8, Name = "2", NFPAType = Models.NFPATypeEnum.Flammability, Description = Models.NFPAModel.flam2 };
            yield return new Models.NFPAModel() { ID = 9, Name = "3", NFPAType = Models.NFPATypeEnum.Flammability, Description = Models.NFPAModel.flam3 };
            yield return new Models.NFPAModel() { ID = 10, Name = "4", NFPAType = Models.NFPATypeEnum.Flammability, Description = Models.NFPAModel.flam4 };

            yield return new Models.NFPAModel() { ID = 11, Name = "0", NFPAType = Models.NFPATypeEnum.Reactivity, Description = Models.NFPAModel.react0 };
            yield return new Models.NFPAModel() { ID = 12, Name = "1", NFPAType = Models.NFPATypeEnum.Reactivity, Description = Models.NFPAModel.react1 };
            yield return new Models.NFPAModel() { ID = 13, Name = "2", NFPAType = Models.NFPATypeEnum.Reactivity, Description = Models.NFPAModel.react2 };
            yield return new Models.NFPAModel() { ID = 14, Name = "3", NFPAType = Models.NFPATypeEnum.Reactivity, Description = Models.NFPAModel.react3 };
            yield return new Models.NFPAModel() { ID = 15, Name = "4", NFPAType = Models.NFPATypeEnum.Reactivity, Description = Models.NFPAModel.react4 };

            yield return new Models.NFPAModel() { ID = 16, Name = "OX", NFPAType = Models.NFPATypeEnum.Special, Description = Models.NFPAModel.specOX };
            yield return new Models.NFPAModel() { ID = 17, Name = "ACID", NFPAType = Models.NFPATypeEnum.Special, Description = Models.NFPAModel.specACID };
            yield return new Models.NFPAModel() { ID = 18, Name = "ALK", NFPAType = Models.NFPATypeEnum.Special, Description = Models.NFPAModel.specALK };
            yield return new Models.NFPAModel() { ID = 19, Name = "COR", NFPAType = Models.NFPATypeEnum.Special, Description = Models.NFPAModel.specCOR };
            yield return new Models.NFPAModel() { ID = 20, Name = "W", NFPAType = Models.NFPATypeEnum.Special, Description = Models.NFPAModel.specW };
            yield return new Models.NFPAModel() { ID = 21, Name = "SA", NFPAType = Models.NFPATypeEnum.Special, Description = Models.NFPAModel.specSA };
            yield return new Models.NFPAModel() { ID = 22, Name = "SKULL", NFPAType = Models.NFPATypeEnum.Special, Description = Models.NFPAModel.specSkull };
            yield return new Models.NFPAModel() { ID = 23, Name = "RAD", NFPAType = Models.NFPATypeEnum.Special, Description = Models.NFPAModel.specRad };
            yield return new Models.NFPAModel() { ID = 24, Name = "EXP", NFPAType = Models.NFPATypeEnum.Special, Description = Models.NFPAModel.specExp };
        }

    }
}
