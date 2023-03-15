using ISOBLL;
using ISOService_API;
using ISOServiceVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ISOService_API
{
    public class ISOService : ISOIService
    {
        #region User

        public UserVO GetUser(string name, string password)
        {
            try
            {
                UserBLL BLL = new UserBLL();
                return BLL.GetUser(name, password);
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllUser Exception!");
            }
        }
        public byte[] GetUserImageByUserID(int userID)
        {
            try
            {
                UserBLL BLL = new UserBLL();
                return BLL.GetUserImageByUserID(userID);
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetUserImageByUserID Exception!");
            }
        }

        public List<UserVO> GetAllUser()
        {
            try
            {
                UserBLL BLL = new UserBLL();
                return BLL.GetAllUser();
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllUser Exception!");
            }
        }

        public List<UserVO> GetActiveUser(bool status)
        {
            try
            {
                UserBLL BLL = new UserBLL();
                return BLL.GetActiveUser(status);
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetActiveUser Exception!");
            }
        }

        public void AddUser(UserVO UserVO)
        {
            try
            {
                UserBLL BLL = new UserBLL();
                BLL.AddUser(UserVO);
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddUser Exception!");
            }
        }

        public void EditUser(UserVO UserVO)
        {
            try
            {
                UserBLL BLL = new UserBLL();
                BLL.EditUser(UserVO);
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditUser Exception!");
            }
        }

        public void UpdateUser(int userID, int personID, string personName, string email, string password)
        {
            try
            {
                UserBLL BLL = new UserBLL();
                BLL.UpdateUser(userID, personID, personName, email, password);
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "UpdateUser Exception!");
            }
        }

        #endregion

        #region UserRole

        public List<UserRoleVO> GetAllUserRole()
        {
            try
            {
                UserRoleBLL BLL = new UserRoleBLL();
                return BLL.GetAllUserRole();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllUserRole Exception!");
            }
        }

        public List<UserRoleVO> GetActiveUserRole(bool status)
        {
            try
            {
                UserRoleBLL BLL = new UserRoleBLL();
                return BLL.GetActiveUserRole(status);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetActiveUserRole Exception!");
            }
        }

        public void AddUserRole(UserRoleVO UserRoleVO)
        {
            try
            {
                UserRoleBLL BLL = new UserRoleBLL();
                BLL.AddUserRole(UserRoleVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddUserRole Exception!");
            }
        }

        public void EditUserRole(UserRoleVO UserRoleVO)
        {
            try
            {
                UserRoleBLL BLL = new UserRoleBLL();
                BLL.EditUserRole(UserRoleVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditUserRole Exception!");
            }
        }

        #endregion

        #region FormMenu

        public List<FormMenuVO> GetActiveFormMenu()
        {
            try
            {
                FormMenuBLL BLL = new FormMenuBLL();
                return BLL.GetActiveFormMenu();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetActiveFormMenu Exception!");
            }
        }

        public List<FormMenuVO> GetAllFormMenu()
        {
            try
            {
                FormMenuBLL BLL = new FormMenuBLL();
                return BLL.GetAllFormMenu();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllFormMenu Exception!");
            }
        }

        public void AddFormMenu(FormMenuVO FormMenuVO)
        {
            try
            {
                FormMenuBLL BLL = new FormMenuBLL();
                BLL.AddFormMenu(FormMenuVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddFormMenu Exception!");
            }
        }

        public void EditFormMenu(FormMenuVO FormMenuVO)
        {
            try
            {
                FormMenuBLL BLL = new FormMenuBLL();
                BLL.EditFormMenu(FormMenuVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditFormMenu Exception!");
            }
        }

        #endregion

        #region BuildingType

        public List<BuildingTypeVO> GetAllBuildingType()
        {
            try
            {
                BuildingTypeBLL BLL = new BuildingTypeBLL();
                return BLL.GetAllBuildingType();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllBuildingType Exception!");
            }
        }

        public List<BuildingTypeVO> GetActiveBuildingType(bool status)
        {
            try
            {
                BuildingTypeBLL BLL = new BuildingTypeBLL();
                return BLL.GetActiveBuildingType(status);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetActiveBuildingType Exception!");
            }
        }

        public void AddBuildingType(BuildingTypeVO BuildingTypeVO)
        {
            try
            {
                BuildingTypeBLL BLL = new BuildingTypeBLL();
                BLL.AddBuildingType(BuildingTypeVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddBuildingType Exception!");
            }
        }

        public void EditBuildingType(BuildingTypeVO BuildingTypeVO)
        {
            try
            {
                BuildingTypeBLL BLL = new BuildingTypeBLL();
                BLL.EditBuildingType(BuildingTypeVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditBuildingType Exception!");
            }
        }

        #endregion

        #region Site

        public List<SiteVO> GetAllSite()
        {
            try
            {
                SiteBLL BLL = new SiteBLL();
                return BLL.GetAllSite();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllSite Exception!");
            }
        }

        public List<SiteVO> GetActiveSite(bool status)
        {
            try
            {
                SiteBLL BLL = new SiteBLL();
                return BLL.GetActiveSite(status);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetActiveSite Exception!");
            }
        }

        public List<SiteVO> GetIsCompleteSite(bool isCompleteStatus, bool activeStatus)
        {
            try
            {
                SiteBLL BLL = new SiteBLL();
                return BLL.GetIsCompleteSite(isCompleteStatus, activeStatus);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetIsCompleteSite Exception!");
            }
        }

        public void AddSite(SiteVO SiteVO)
        {
            try
            {
                SiteBLL BLL = new SiteBLL();
                BLL.AddSite(SiteVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddSite Exception!");
            }
        }

        public void EditSite(SiteVO SiteVO)
        {
            try
            {
                SiteBLL BLL = new SiteBLL();
                BLL.EditSite(SiteVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditSite Exception!");
            }
        }

        public string GetNewSiteCode()
        {
            try
            {
                SiteBLL BLL = new SiteBLL();
                return BLL.GetNewSiteCode();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetNewSiteCode Exception!");
            }
        }

        public List<SiteVO> GetAllProjectByUserID(int id)
        {
            try
            {
                SiteBLL BLL = new SiteBLL();
                return BLL.GetAllProjectByUserID(id);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllProjectByUserID Exception!");
            }
        }

        #endregion

        #region Person

        public List<PersonVO> GetAllPerson()
        {
            try
            {
                PersonBLL BLL = new PersonBLL();
                return BLL.GetAllPerson();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllPerson Exception!");
            }
        }

        public List<PersonVO> GetActivePerson(bool status)
        {
            try
            {
                PersonBLL BLL = new PersonBLL();
                return BLL.GetActivePerson(status);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetActivePerson Exception!");
            }
        }

        public void AddPerson(PersonVO PersonVO)
        {
            try
            {
                PersonBLL BLL = new PersonBLL();
                BLL.AddPerson(PersonVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddPerson Exception!");
            }
        }

        public void EditPerson(PersonVO PersonVO)
        {
            try
            {
                PersonBLL BLL = new PersonBLL();
                BLL.EditPerson(PersonVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditPerson Exception!");
            }
        }

        #endregion

        #region PersonAndSite

        public List<PersonAndSiteVO> GetAllPersonAndSite()
        {
            try
            {
                PersonAndSiteBLL BLL = new PersonAndSiteBLL();
                return BLL.GetAllPersonAndSite();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllPersonAndSite Exception!");
            }
        }

        public List<PersonAndSiteVO> GetAllPersonAndSiteBySiteIDAndPersonID(int siteID, int personID)
        {
            try
            {
                PersonAndSiteBLL BLL = new PersonAndSiteBLL();
                return BLL.GetAllPersonAndSiteBySiteIDAndPersonID(siteID, personID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllPersonAndSiteBySiteIDAndPersonID Exception!");
            }
        }

        public List<PersonAndSiteVO> GetAllPersonAndSiteByPersonID(int personID)
        {
            try
            {
                PersonAndSiteBLL BLL = new PersonAndSiteBLL();
                return BLL.GetAllPersonAndSiteByPersonID(personID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllPersonAndSiteByPersonID Exception!");
            }
        }

        public PersonAndSiteVO GetAllPersonAndSiteBySiteIDAndResponsibilityTypeID(int siteID, int responsibilityTypeID)
        {
            try
            {
                PersonAndSiteBLL BLL = new PersonAndSiteBLL();
                return BLL.GetAllPersonAndSiteBySiteIDAndResponsibilityTypeID(siteID, responsibilityTypeID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllPersonAndSiteBySiteIDAndResponsibilityTypeID Exception!");
            }
        }

        public List<PersonAndSiteVO> GetFinishedPersonAndSite(bool status)
        {
            try
            {
                PersonAndSiteBLL BLL = new PersonAndSiteBLL();
                return BLL.GetFinishedPersonAndSite(status);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetFinishedPersonAndSite Exception!");
            }
        }

        public void AddPersonAndSite(PersonAndSiteVO PersonAndSiteVO)
        {
            try
            {
                PersonAndSiteBLL BLL = new PersonAndSiteBLL();
                BLL.AddPersonAndSite(PersonAndSiteVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddPersonAndSite Exception!");
            }
        }

        public void EditPersonAndSite(PersonAndSiteVO PersonAndSiteVO)
        {
            try
            {
                PersonAndSiteBLL BLL = new PersonAndSiteBLL();
                BLL.EditPersonAndSite(PersonAndSiteVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditPersonAndSite Exception!");
            }
        }
        #endregion

        #region PersonType

        public List<PersonTypeVO> GetAllPersonType()
        {
            try
            {
                PersonTypeBLL BLL = new PersonTypeBLL();
                return BLL.GetAllPersonType();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllPersonType Exception!");
            }
        }

        public List<PersonTypeVO> GetActivePersonType(bool status)
        {
            try
            {
                PersonTypeBLL BLL = new PersonTypeBLL();
                return BLL.GetActivePersonType(status);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetActivePersonType Exception!");
            }
        }

        public void AddPersonType(PersonTypeVO PersonTypeVO)
        {
            try
            {
                PersonTypeBLL BLL = new PersonTypeBLL();
                BLL.AddPersonType(PersonTypeVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddPersonType Exception!");
            }
        }

        public void EditPersonType(PersonTypeVO PersonTypeVO)
        {
            try
            {
                PersonTypeBLL BLL = new PersonTypeBLL();
                BLL.EditPersonType(PersonTypeVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditPersonType Exception!");
            }
        }

        #endregion

        #region ResponsibilityType

        public List<ResponsibilityTypeVO> GetAllResponsibilityType()
        {
            try
            {
                ResponsibilityTypeBLL BLL = new ResponsibilityTypeBLL();
                return BLL.GetAllResponsibilityType();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllResponsibilityType Exception!");
            }
        }

        public ResponsibilityTypeVO GetAllResponsibilityTypeByType(String type)
        {
            try
            {
                ResponsibilityTypeBLL BLL = new ResponsibilityTypeBLL();
                return BLL.GetAllResponsibilityTypeByType(type);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllResponsibilityTypeByType Exception!");
            }
        }

        public void AddResponsibilityType(ResponsibilityTypeVO ResponsibilityTypeVO)
        {
            try
            {
                ResponsibilityTypeBLL BLL = new ResponsibilityTypeBLL();
                BLL.AddResponsibilityType(ResponsibilityTypeVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddResponsibilityType Exception!");
            }
        }

        public void EditResponsibilityType(ResponsibilityTypeVO ResponsibilityTypeVO)
        {
            try
            {
                ResponsibilityTypeBLL BLL = new ResponsibilityTypeBLL();
                BLL.EditResponsibilityType(ResponsibilityTypeVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditResponsibilityType Exception!");
            }
        }

        #endregion

        #region OperationOrderReg

        public List<OperationOrderRegVO> GetAllOperationOrderReg()
        {
            try
            {
                OperationOrderRegBLL BLL = new OperationOrderRegBLL();
                return BLL.GetAllOperationOrderReg();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllOperationOrderReg Exception!");
            }
        }

        public void AddOperationOrderReg(OperationOrderRegVO OperationOrderRegVO)
        {
            try
            {
                OperationOrderRegBLL BLL = new OperationOrderRegBLL();
                BLL.AddOperationOrderReg(OperationOrderRegVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddOperationOrderReg Exception!");
            }
        }

        public void EditOperationOrderReg(OperationOrderRegVO OperationOrderRegVO)
        {
            try
            {
                OperationOrderRegBLL BLL = new OperationOrderRegBLL();
                BLL.EditOperationOrderReg(OperationOrderRegVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditOperationOrderReg Exception!");
            }
        }

        public string GetNewOrderNo(int siteID)
        {
            try
            {
                OperationOrderRegBLL BLL = new OperationOrderRegBLL();
                return BLL.GetNewOrderNo(siteID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetNewOrderNo Exception!");
            }
        }

        public OperationOrderRegVO GetOperationOrderRegByOORID(int OORID)
        {
            try
            {
                OperationOrderRegBLL BLL = new OperationOrderRegBLL();
                return BLL.GetOperationOrderRegByOORID(OORID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetOperationOrderByOrderID Exception!");
            }
        }

        public List<OperationOrderRegVO> GetOORListByFilter(DateTime fromDate, DateTime toDate, int siteID, int buildingID, string orderNo)
        {
            try
            {
                OperationOrderRegBLL BLL = new OperationOrderRegBLL();
                return BLL.GetOORListByFilter(fromDate, toDate, siteID, buildingID, orderNo);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetOORListByFilter Exception!");
            }
        }

        #endregion

        #region OperationOrder

        public List<OperationOrderVO> GetAllOperationOrder()
        {
            try
            {
                OperationOrderBLL BLL = new OperationOrderBLL();
                return BLL.GetAllOperationOrder();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllOperationOrder Exception!");
            }
        }

        public void AddOperationOrder(OperationOrderVO OperationOrderVO)
        {
            try
            {
                OperationOrderBLL BLL = new OperationOrderBLL();
                BLL.AddOperationOrder(OperationOrderVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddOperationOrder Exception!");
            }
        }

        public void EditOperationOrder(OperationOrderVO OperationOrderVO)
        {
            try
            {
                OperationOrderBLL BLL = new OperationOrderBLL();
                BLL.EditOperationOrder(OperationOrderVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditOperationOrder Exception!");
            }
        }

        public List<OperationOrderVO> GetOperationOrderCompletePrepare()
        {
            try
            {
                OperationOrderBLL BLL = new OperationOrderBLL();
                return BLL.GetOperationOrderCompletePrepare();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetOperationOrderCompletePrepare Exception!");
            }
        }

        public List<OperationOrderVO> GetOperationOrderCompleteApprove()
        {
            try
            {
                OperationOrderBLL BLL = new OperationOrderBLL();
                return BLL.GetOperationOrderCompleteApprove();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetOperationOrderCompleteApprove Exception!");
            }
        }

        public List<OperationOrderVO> GetOOListByFilter(string orderNo)
        {
            try
            {
                OperationOrderBLL BLL = new OperationOrderBLL();
                return BLL.GetOOListByFilter(orderNo);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetOOListByFilter Exception!");
            }
        }

        #endregion

        #region NameOfWork

        public List<NameOfWorkVO> GetAllNameOfWork()
        {
            try
            {
                NameOfWorkBLL BLL = new NameOfWorkBLL();
                return BLL.GetAllNameOfWork();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllNameOfWork Exception!");
            }
        }
        public List<NameOfWorkVO> GetAllNameOfWorkByOPTypeID(int opTypeID)
        {
            try
            {
                NameOfWorkBLL BLL = new NameOfWorkBLL();
                return BLL.GetAllNameOfWorkByOPTypeID(opTypeID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllNameOfWorkByOPTypeID Exception!");
            }
        }
        public List<NameOfWorkVO> GetActiveNameOfWork(bool status)
        {
            try
            {
                NameOfWorkBLL BLL = new NameOfWorkBLL();
                return BLL.GetActiveNameOfWork(status);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetActiveNameOfWork Exception!");
            }
        }

        public void AddNameOfWork(NameOfWorkVO NameOfWorkVO)
        {
            try
            {
                NameOfWorkBLL BLL = new NameOfWorkBLL();
                BLL.AddNameOfWork(NameOfWorkVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddNameOfWork Exception!");
            }
        }

        public void EditNameOfWork(NameOfWorkVO NameOfWorkVO)
        {
            try
            {
                NameOfWorkBLL BLL = new NameOfWorkBLL();
                BLL.EditNameOfWork(NameOfWorkVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditNameOfWork Exception!");
            }
        }

        #endregion

        #region OPType

        public List<OPTypeVO> GetAllOPType()
        {
            try
            {
                OPTypeBLL BLL = new OPTypeBLL();
                return BLL.GetAllOPType();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllOPType Exception!");
            }
        }

        #endregion

        #region MonthlyPlan

        public List<MonthlyPlanVO> GetAllMonthlyPlan()
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                return BLL.GetAllMonthlyPlan();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllMonthlyPlan Exception!");
            }
        }

        public void AddMonthlyPlan(AddMonthlyPlanVO addMonthlyPlanVO)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                BLL.AddMonthlyPlan(addMonthlyPlanVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddMonthlyPlan Exception!");
            }
        }

        public void EditMonthlyPlan(MonthlyPlanVO MonthlyPlanVO)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                BLL.EditMonthlyPlan(MonthlyPlanVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditMonthlyPlan Exception!");
            }
        }

        public void DeleteMonthlyPlan(MonthlyPlanVO MonthlyPlanVO)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                BLL.DeleteMonthlyPlan(MonthlyPlanVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "DeleteMonthlyPlan Exception!");
            }
        }

        public List<MonthlyPlanSummaryVO> GetMonthlyPlanByFilter(DateTime date, int siteID)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                return BLL.GetMonthlyPlanByFilter(date, siteID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetMonthlyPlanByFilter Exception!");
            }
        }

        public List<MonthlyPlanVO> GetAllMonthlyPlanBySiteIDAndPersonRole(int siteID, string personRole)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                return BLL.GetAllMonthlyPlanBySiteIDAndPersonRole(siteID, personRole);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllMonthlyPlanBySiteIDAndPersonRole Exception!");
            }
        }

        public List<MonthlyPlanVO> GetAllMonthlyPlanByPersonIDAndPersonRole(int personID, string personRole)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                return BLL.GetAllMonthlyPlanByPersonIDAndPersonRole(personID,personRole);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllMonthlyPlanByPersonIDAndPersonRole Exception!");
            }
        }

        public List<MonthlyPlanDetailVO> GetAllMonthlyPlanDetailsBySiteIDAndForthemonth(int siteID, DateTime month)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                return BLL.GetAllMonthlyPlanDetailsBySiteIDAndForthemonth(siteID, month);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllMonthlyPlanDetailsBySiteIDAndForthemonth Exception!");
            }
        }

        public List<MonthlyPlanDetailVO> GetAllMonthlyPlanDetailsByMOPIDAndNameOfWorkID(int mopID, int nameOfWorkID)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                return BLL.GetAllMonthlyPlanDetailsByMOPIDAndNameOfWorkID(mopID, nameOfWorkID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllMonthlyPlanDetailsByMOPIDAndNameOfWorkID Exception!");
            }
        }

        public MonthlyPlanDetailVO GetMonthlyPlanDetailsIDByMOPIDAndNameOfWorkID(int mopID, int nameOfWorkID)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                return BLL.GetMonthlyPlanDetailsIDByMOPIDAndNameOfWorkID(mopID, nameOfWorkID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetMonthlyPlanDetailsIDByMOPIDAndNameOfWorkID Exception!");
            }
        }

        public void DeleteMonthlyPlanBySiteIDAndForTheMonth(int siteID, string forMonth)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                BLL.DeleteMonthlyPlanBySiteIDAndForTheMonth(siteID, forMonth);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "DeleteMonthlyPlanBySiteIDAndForTheMonth Exception!");
            }
        }

        public void UpdateMonthlyPlanStatusByMOPID(int mopID)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                BLL.UpdateMonthlyPlanStatusByMOPID(mopID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "UpdateMonthlyPlanStatusByMOPID Exception!");
            }
        }

        public void UpdateMonthlyPlanStatusByMOPIDAndPersonRoleAndStatus(int mopID, string personRole, string status)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                BLL.UpdateMonthlyPlanStatusByMOPIDAndPersonRoleAndStatus(mopID, personRole, status);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "UpdateMonthlyPlanStatusByMOPIDAndPersonRoleAndStatus Exception!");
            }
        }


        public List<MonthlyPlanVO> GetAllMonthlyPlanBySiteIDAndForTheMonth(int siteID, string forMonth)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                return BLL.GetAllMonthlyPlanBySiteIDAndForTheMonth(siteID, forMonth);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllMonthlyPlanBySiteIDAndForTheMonth Exception!");
            }
        }

        public MonthlyPlanVO GetMonthlyPlanBySiteIDAndForTheMonth(int siteID, string forMonth)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                return BLL.GetMonthlyPlanBySiteIDAndForTheMonth(siteID, forMonth);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetMonthlyPlanBySiteIDAndForTheMonth Exception!");
            }
        }

        public void AddMonthlyPlanDetail(List<MonthlyPlanDetailByStringValueVO> detailPlanList)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                BLL.AddMonthlyPlanDetail(detailPlanList);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddMonthlyPlanDetail Exception!");
            }
        }

        public void UpdateMonthlyPlanDetail(List<MonthlyPlanDetailByStringValueVO> planDetail)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                BLL.UpdateMonthlyPlanDetail(planDetail);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "UpdateMonthlyPlanDetail Exception!");
            }
        }

        public void AddMonthlyPlanDetailByPlanDate(List<PlanDateByStringValueVO> detailPlanDateList)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                BLL.AddMonthlyPlanDetailByPlanDate(detailPlanDateList);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddMonthlyPlanDetailByPlanDate Exception!");
            }
        }

        public void AddMonthlyPlanDetailByActualDate(List<ActualDateByStringValueVO> detailActualDateList)
        {
            try
            {
                MonthlyPlanBLL BLL = new MonthlyPlanBLL();
                BLL.AddMonthlyPlanDetailByActualDate(detailActualDateList);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddMonthlyPlanDetailByActualDate Exception!");
            }
        }
        #endregion

        #region WeeklyPlan

        public List<WeeklyPlanVO> GetAllWeeklyPlan()
        {
            try
            {
                WeeklyPlanBLL BLL = new WeeklyPlanBLL();
                return BLL.GetAllWeeklyPlan();
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetAllWeeklyPlan Exception!");
            }
        }

        public void AddWeeklyPlan(WeeklyPlanVO WeeklyPlanVO)
        {
            try
            {
                WeeklyPlanBLL BLL = new WeeklyPlanBLL();
                BLL.AddWeeklyPlan(WeeklyPlanVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "AddWeeklyPlan Exception!");
            }
        }

        public void EditWeeklyPlan(WeeklyPlanVO WeeklyPlanVO)
        {
            try
            {
                WeeklyPlanBLL BLL = new WeeklyPlanBLL();
                BLL.EditWeeklyPlan(WeeklyPlanVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "EditWeeklyPlan Exception!");
            }
        }

        public void DeleteWeeklyPlan(WeeklyPlanVO WeeklyPlanVO)
        {
            try
            {
                WeeklyPlanBLL BLL = new WeeklyPlanBLL();
                BLL.DeleteWeeklyPlan(WeeklyPlanVO);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "DeleteWeeklyPlan Exception!");
            }
        }

        public List<WeeklyPlanDetailVO> GetWeeklyPlanByFilter(DateTime date, int siteID)
        {
            try
            {
                WeeklyPlanBLL BLL = new WeeklyPlanBLL();
                return BLL.GetWeeklyPlanByFilter(date, siteID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetWeeklyPlanByFilter Exception!");
            }
        }

        #endregion

        #region MasterSchedulePDF

        public List<MasterSchedulePDFVO> GetMasterSchedulePDFListBySite(int siteID)
        {
            try
            {
                MasterSchedulePDFBLL BLL = new MasterSchedulePDFBLL();
                return BLL.GetMasterSchedulePDFListBySite(siteID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetMasterSchedulePDFListBySite Exception!");
            }
        }

        #endregion

        #region MasterSchedulePDF

        public List<DailyPlanDetailVO> GetDailyPlanByFilter(DateTime date, int siteID)
        {
            try
            {
                DailyPlanBLL BLL = new DailyPlanBLL();
                return BLL.GetDailyPlanByFilter(date, siteID);
            }
            catch (Exception ex)
            {
                throw new FaultException<ServerSvcFault>(new ServerSvcFault(ex.Message), "GetDailyPlanByFilter Exception!");
            }
        }

        #endregion
    }
}
