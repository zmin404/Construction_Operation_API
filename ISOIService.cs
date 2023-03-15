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
    [ServiceContract]
    public interface ISOIService
    {
        #region User

        [OperationContract]
        //[WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetUser/{name}/{password}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetUser?name={name}&password={password}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        UserVO GetUser(string name, string password);

        [OperationContract]
        [WebGet(UriTemplate = "/GetUserImageByUserID?userID={userID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        byte[] GetUserImageByUserID(int userID);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllUser", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<UserVO> GetAllUser();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetActiveUser/resource?status={status}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [FaultContract(typeof(ServerSvcFault))]
        List<UserVO> GetActiveUser(bool status);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddUser", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddUser(UserVO userVO);  

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditUser", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        //[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        void EditUser(UserVO UserVO);


        [OperationContract]
        [WebGet(UriTemplate = "/UpdateUser?userID={userID}&personID={personID}&personName={personName}&email={email}&password={password}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        void UpdateUser(int userID, int personID, string personName, string email, string password);

        #endregion

        #region UserRole

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllUserRole", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<UserRoleVO> GetAllUserRole();

        [OperationContract]
        [WebInvoke(Method = "Get", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetActiveUserRole/resource?status={status}",BodyStyle =WebMessageBodyStyle.WrappedRequest)]
        [FaultContract(typeof(ServerSvcFault))]
        List<UserRoleVO> GetActiveUserRole(bool status);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddUserRole", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddUserRole(UserRoleVO UserRoleVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditUserRole", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditUserRole(UserRoleVO UserRoleVO);

        #endregion

        #region FormMenu

        [OperationContract]
        [WebGet(UriTemplate = "/GetActiveFormMenu", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<FormMenuVO> GetActiveFormMenu();

        //For System Configure
        [OperationContract]
        [WebGet(UriTemplate = "/GetAllFormMenu", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<FormMenuVO> GetAllFormMenu();

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddFormMenu", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddFormMenu(FormMenuVO FormMenuVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditFormMenu", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditFormMenu(FormMenuVO FormMenuVO);

        #endregion

        #region BuildingType

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllBuildingType", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<BuildingTypeVO> GetAllBuildingType();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetActiveBuildingType/resource?status={status}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [FaultContract(typeof(ServerSvcFault))]
        List<BuildingTypeVO> GetActiveBuildingType(bool status);

        [OperationContract]

        [WebInvoke(UriTemplate = "/AddBuildingType", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddBuildingType(BuildingTypeVO BuildingTypeVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditBuildingType", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditBuildingType(BuildingTypeVO BuildingTypeVO);

        #endregion

        #region Site

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetAllSite", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [FaultContract(typeof(ServerSvcFault))]
        List<SiteVO> GetAllSite();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetActiveSite/resource?status={status}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [FaultContract(typeof(ServerSvcFault))]
        List<SiteVO> GetActiveSite(bool status);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetIsCompleteSite/resource?isCompleteStatus={isCompleteStatus}&activeStatus={activeStatus}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [FaultContract(typeof(ServerSvcFault))]
        List<SiteVO> GetIsCompleteSite(bool isCompleteStatus, bool activeStatus);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddSite", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddSite(SiteVO SiteVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditSite", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditSite(SiteVO SiteVO);

        [OperationContract]
        [WebGet(UriTemplate = "/GetNewSiteCode", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        string GetNewSiteCode();

        [OperationContract]
        //[WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetAllProjectByUserID?id={id}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetAllProjectByUserID?id={id}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]

        [FaultContract(typeof(ServerSvcFault))]
        List<SiteVO> GetAllProjectByUserID(int id);

        #endregion

        #region Person

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllPerson", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<PersonVO> GetAllPerson();

        [OperationContract]
        [WebInvoke(Method = "Get", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetActivePerson/resource?status={status}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [FaultContract(typeof(ServerSvcFault))]
        List<PersonVO> GetActivePerson(bool status);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddPerson", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddPerson(PersonVO PersonVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditPerson", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditPerson(PersonVO PersonVO);
        #endregion

        #region PersonAndSite

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllPersonAndSite", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<PersonAndSiteVO> GetAllPersonAndSite();

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllPersonAndSiteBySiteIDAndPersonID?siteID={siteID}&personID={personID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<PersonAndSiteVO> GetAllPersonAndSiteBySiteIDAndPersonID(int siteID, int personID);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllPersonAndSiteByPersonID?personID={personID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<PersonAndSiteVO> GetAllPersonAndSiteByPersonID(int personID);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllPersonAndSiteBySiteIDAndResponsibilityTypeID?siteID={siteID}&responsibilityTypeID={responsibilityTypeID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        PersonAndSiteVO GetAllPersonAndSiteBySiteIDAndResponsibilityTypeID(int siteID, int responsibilityTypeID);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetFinishedPersonAndSite/resource?status={status}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [FaultContract(typeof(ServerSvcFault))]
        List<PersonAndSiteVO> GetFinishedPersonAndSite(bool status);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddPersonAndSite", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddPersonAndSite(PersonAndSiteVO PersonAndSiteVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditPersonAndSite", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditPersonAndSite(PersonAndSiteVO PersonAndSiteVO);
        #endregion

        #region PersonType
        [OperationContract]
        [WebGet(UriTemplate = "/GetAllPersonType", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<PersonTypeVO> GetAllPersonType();

        [OperationContract]
        [WebInvoke(Method = "Get", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetActivePersonType/resource?status={status}",BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [FaultContract(typeof(ServerSvcFault))]
        List<PersonTypeVO> GetActivePersonType(bool status);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddPersonType", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddPersonType(PersonTypeVO PersonTypeVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditPersonType", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditPersonType(PersonTypeVO PersonTypeVO);

        #endregion

        #region ResponsibilityType

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllResponsibilityType", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<ResponsibilityTypeVO> GetAllResponsibilityType();

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllResponsibilityTypeByType?type={type}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        ResponsibilityTypeVO GetAllResponsibilityTypeByType(String type);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddResponsibilityType", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddResponsibilityType(ResponsibilityTypeVO ResponsibilityTypeVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditResponsibilityType", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditResponsibilityType(ResponsibilityTypeVO ResponsibilityTypeVO);

        #endregion

        #region OperationOrderReg

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllOperationOrderReg", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<OperationOrderRegVO> GetAllOperationOrderReg();

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddOperationOrderReg", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddOperationOrderReg(OperationOrderRegVO OperationOrderRegVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditOperationOrderReg", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditOperationOrderReg(OperationOrderRegVO OperationOrderRegVO);

        [OperationContract]
        [WebGet(UriTemplate = "/GetNewOrderNo?siteIID={siteID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        string GetNewOrderNo(int siteID);


        [OperationContract]
        [WebGet(UriTemplate = "/GetOperationOrderRegByOORID?OORID={OORID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        OperationOrderRegVO GetOperationOrderRegByOORID(int OORID);

        [OperationContract]
        [WebGet(UriTemplate = "/GetOORListByFilter?fromDate={fromDate}&toDate={toDate}&siteID={siteID}&buildingID={buildingID}&orderNo={orderNo}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<OperationOrderRegVO> GetOORListByFilter(DateTime fromDate, DateTime toDate, int siteID, int buildingID, string orderNo);

        #endregion

        #region OperationOrder

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllOperationOrder", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<OperationOrderVO> GetAllOperationOrder();

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddOperationOrder", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddOperationOrder(OperationOrderVO OperationOrderVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditOperationOrder", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditOperationOrder(OperationOrderVO OperationOrderVO);

        [OperationContract]
        [WebGet(UriTemplate = "/GetOperationOrderCompletePrepare", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<OperationOrderVO> GetOperationOrderCompletePrepare();

        [OperationContract]
        [WebGet(UriTemplate = "/GetOperationOrderCompleteApprove", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<OperationOrderVO> GetOperationOrderCompleteApprove();

        [OperationContract]
        [WebGet(UriTemplate = "/GetOOListByFilter/{orderNo}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<OperationOrderVO> GetOOListByFilter(string orderNo);

        #endregion

        #region NameOfWork

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllNameOfWork", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<NameOfWorkVO> GetAllNameOfWork();

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllNameOfWorkByOPTypeID?opTypeID={opTypeID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<NameOfWorkVO> GetAllNameOfWorkByOPTypeID(int opTypeID);

        [OperationContract]
        [WebInvoke(Method = "Get", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetActiveNameOfWork/resource?status={status}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [FaultContract(typeof(ServerSvcFault))]
        List<NameOfWorkVO> GetActiveNameOfWork(bool status);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddNameOfWork", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddNameOfWork(NameOfWorkVO NameOfWorkVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditNameOfWork", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditNameOfWork(NameOfWorkVO NameOfWorkVO);

        #endregion

        #region OPType

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllOPType", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<OPTypeVO> GetAllOPType();

        #endregion

        #region MonthlyPlan

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllMonthlyPlan", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<MonthlyPlanVO> GetAllMonthlyPlan();

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddMonthlyPlan", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddMonthlyPlan(AddMonthlyPlanVO addMonthlyPlanVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditMonthlyPlan", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditMonthlyPlan(MonthlyPlanVO MonthlyPlanVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/DeleteMonthlyPlan", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        [FaultContract(typeof(ServerSvcFault))]
        void DeleteMonthlyPlan(MonthlyPlanVO MonthlyPlanVO);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllMonthlyPlan?date={date}&siteID={siteID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<MonthlyPlanSummaryVO> GetMonthlyPlanByFilter(DateTime date, int siteID);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllMonthlyPlanBySiteIDAndPersonRole?siteID={siteID}&personRole={personRole}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<MonthlyPlanVO> GetAllMonthlyPlanBySiteIDAndPersonRole(int siteID, string personRole);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllMonthlyPlanByPersonIDAndPersonRole?personID={personID}&personRole={personRole}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<MonthlyPlanVO> GetAllMonthlyPlanByPersonIDAndPersonRole(int personID,string personRole);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllMonthlyPlanDetailsBySiteIDAndForthemonth?siteID={siteID}&month={month}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<MonthlyPlanDetailVO> GetAllMonthlyPlanDetailsBySiteIDAndForthemonth(int siteID, DateTime month);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllMonthlyPlanDetailsByMOPIDAndNameOfWorkID?mopID={mopID}&nameOfWorkID={nameOfWorkID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<MonthlyPlanDetailVO> GetAllMonthlyPlanDetailsByMOPIDAndNameOfWorkID(int mopID, int nameOfWorkID);

        [OperationContract]
        [WebGet(UriTemplate = "/GetMonthlyPlanDetailsIDByMOPIDAndNameOfWorkID?mopID={mopID}&nameOfWorkID={nameOfWorkID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        MonthlyPlanDetailVO GetMonthlyPlanDetailsIDByMOPIDAndNameOfWorkID(int mopID, int nameOfWorkID);

        [OperationContract]
        [WebGet(UriTemplate = "/DeleteMonthlyPlanBySiteIDAndForTheMonth?siteID={siteID}&forMonth={forMonth}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        void DeleteMonthlyPlanBySiteIDAndForTheMonth(int siteID, string forMonth);

        [OperationContract]
        [WebGet(UriTemplate = "/UpdateMonthlyPlanStatusByMOPID?mopID={mopID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        void UpdateMonthlyPlanStatusByMOPID(int mopID);

        [OperationContract]
        [WebGet(UriTemplate = "/UpdateMonthlyPlanStatusByMOPIDAndPersonRoleAndStatus?mopID={mopID}&personRole={personRole}&status={status}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        void UpdateMonthlyPlanStatusByMOPIDAndPersonRoleAndStatus(int mopID, string personRole, string status);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllMonthlyPlanBySiteIDAndForTheMonth?siteID={siteID}&forMonth={forMonth}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<MonthlyPlanVO> GetAllMonthlyPlanBySiteIDAndForTheMonth(int siteID, string forMonth);

        [OperationContract]
        [WebGet(UriTemplate = "/GetMonthlyPlanBySiteIDAndForTheMonth?siteID={siteID}&forMonth={forMonth}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        MonthlyPlanVO GetMonthlyPlanBySiteIDAndForTheMonth(int siteID, string forMonth);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddMonthlyPlanDetail", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddMonthlyPlanDetail(List<MonthlyPlanDetailByStringValueVO> detailPlanList);

        [OperationContract]
        [WebInvoke(UriTemplate = "/UpdateMonthlyPlanDetail", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void UpdateMonthlyPlanDetail(List<MonthlyPlanDetailByStringValueVO> planDetail);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddMonthlyPlanDetailByPlanDate", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddMonthlyPlanDetailByPlanDate(List<PlanDateByStringValueVO> detailPlanDateList);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddMonthlyPlanDetailByActualDate", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddMonthlyPlanDetailByActualDate(List<ActualDateByStringValueVO> detailActualDateList);


        #endregion

        #region WeeklyPlan

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllWeeklyPlan", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<WeeklyPlanVO> GetAllWeeklyPlan();

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddWeeklyPlan", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void AddWeeklyPlan(WeeklyPlanVO WeeklyPlanVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/EditWeeklyPlan", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(ServerSvcFault))]
        void EditWeeklyPlan(WeeklyPlanVO WeeklyPlanVO);

        [OperationContract]
        [WebInvoke(UriTemplate = "/DeleteWeeklyPlan", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        [FaultContract(typeof(ServerSvcFault))]
        void DeleteWeeklyPlan(WeeklyPlanVO WeeklyPlanVO);

        [OperationContract]
        [WebGet(UriTemplate = "/GetWeeklyPlanByFilter?date={date}&siteID={siteID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<WeeklyPlanDetailVO> GetWeeklyPlanByFilter(DateTime date, int siteID);


        #endregion

        #region MasterSchedulePDF

        [OperationContract]
        [WebGet(UriTemplate = "/GetMasterSchedulePDFListBySite?siteID={siteID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<MasterSchedulePDFVO> GetMasterSchedulePDFListBySite(int siteID);

        #endregion

        #region DailyPlan

        [OperationContract]
        [WebGet(UriTemplate = "/GetDailyPlanByFilter?date={date}&siteID={siteID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ServerSvcFault))]
        List<DailyPlanDetailVO> GetDailyPlanByFilter(DateTime date, int siteID);

        #endregion

    }
}
