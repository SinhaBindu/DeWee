﻿using DeWee.Manager;
using DeWee.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
//using OfficeOpenXml;
using static DeWee.Manager.Enums;
using ClosedXML.Excel;

namespace DeWee.Controllers
{
    [Authorize]
    public class ParticipantController : Controller
    {
        DeWee_DBEntities db = new DeWee_DBEntities();
        int results = 0;
        // GET: Participant
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult AddParticipant(Guid? Indt_Id)
        {
            Participant model = new Participant();
            if (Indt_Id != Guid.Empty && Indt_Id != null)
            {
                var tbl = db.tbl_IndtSolarization.Find(Indt_Id);
                if (tbl != null)
                {
                    //model.Indt_Id = tbl.Indt_Id;
                    //model.NameofSHGmember = tbl.NameofSHGMember;
                    //model.YearOfSHG = Convert.ToInt32(tbl.YearOfSHG);
                    //model.PhoneNumber = tbl.PhoneNumber;
                    //model.NameofEnterpriseOwner = tbl.NameofEnterpriseOwner;
                    //model.Age = tbl.Age.Value;
                    //model.EducationQlf_Id = tbl.EducationQlf_Id.Value;
                    //model.Caste_Id = Convert.ToInt32(tbl.Caste_Id);
                    //model.TypeofEnterpriseBusin_Id = Convert.ToInt32(tbl.TypeofEnterpriseBusin_Id);
                    //model.BusinessOwnedType_Id = Convert.ToInt32(tbl.BusinessOwnedType_Id);
                    //model.EstablishedEnterpriseType_Id = Convert.ToInt32(tbl.EstablishedEnterpriseType_Id);
                    //model.TypeOfInvestBusin_Id = Convert.ToInt32(tbl.TypeOfInvestBusin_Id);
                    //model.TookSourceOfLoan_Id = Convert.ToInt32(tbl.TookSourceOfLoan_Id);
                    //model.TookLoanAmt = Convert.ToInt32(tbl.TookLoanAmt);
                    //model.StartBusinessInvestAmt = Convert.ToInt32(tbl.StartBusinessInvestAmt);
                    //model.StartYourBusinessTakeAmt = Convert.ToInt32(tbl.StartYourBusinessTakeAmt);
                    //model.MonthlyProfitBusiness = Convert.ToInt32(tbl.MonthlyProfitBusiness);
                    //model.WorkInEnterprises_FamilyMembers = Convert.ToInt32(tbl.WorkInEnterprises_FamilyMembers);
                    //model.WorkInEnterprises_SHGMembers = Convert.ToInt32(tbl.WorkInEnterprises_SHGMembers);
                    //model.WorkInEnterprises_AssitantStaff = Convert.ToInt32(tbl.WorkInEnterprises_AssitantStaffs);
                    //model.TypeOfMachineEnterprise_Id = Convert.ToInt32(tbl.TypeOfMachineEnterprise_Id);
                    //model.MotorBasedOnMachinesInActualUsed = Convert.ToInt32(tbl.TypeOfMachineEnterprise_Id);
                    //model.MachineryPowerkilowatt_Id = Convert.ToInt32(tbl.MachineryPowerkilowatt_Id);
                    //model.ElectricityConnection_Id = Convert.ToInt32(tbl.ElectricityConnection_Id);
                    //model.ConnectionPhaseofPower_Id = Convert.ToInt32(tbl.ConnectionPhaseofPower_Id);
                    //model.MonthlyElectricityConsumption_Id = Convert.ToInt32(tbl.MonthlyElectricityConsumption_Id);
                    //model.MachineSourceofEnergy_Id = Convert.ToInt32(tbl.MachineSourceofEnergy_Id);
                    //model.MachineSourceofEnergy_Others = tbl.MachineSourceofEnergy_Others;
                    //model.Solar_InKilowatt_Id = Convert.ToInt32(tbl.Solar_InKilowatt_Id);
                    //model.Solar_EnergyPanelYesNo_Id = Convert.ToInt32(tbl.Solar_EnergyPanelYesNo_Id);
                    //model.Solar_ExpenditureIncurredAmt = Convert.ToInt32(tbl.Solar_ExpenditureIncurredAmt);
                    //model.SubsidySolarReceive_Id = Convert.ToInt32(tbl.SubsidySolarReceive_Id);
                    //model.LoanSolarPanelsYesNo_Id = Convert.ToInt32(tbl.LoanSolarPanelsYesNo_Id);
                    //model.MonthAvgAmtSavedDescription_Id = Convert.ToInt32(tbl.MonthAvgAmtSavedDescription_Id);
                    //model.ElectricityUsedHours_Id = Convert.ToInt32(tbl.ElectricityUsedHours_Id);
                    //model.MonthlyExpenseInElectricityBill_Id = Convert.ToInt32(tbl.MonthlyExpenseInElectricityBill_Id);
                    //model.GeneratorElectricityUsedHours_Id = Convert.ToInt32(tbl.GeneratorElectricityUsedHours_Id);
                    //model.MonthlyExpenseFuelSource_Id = Convert.ToInt32(tbl.MonthlyExpenseFuelSource_Id);
                    //model.MonthlyRepairCost_Id = Convert.ToInt32(tbl.MonthlyRepairCost_Id);
                    //model.HeardAboutSolarEYesNo_Id = Convert.ToInt32(tbl.HeardAboutSolarEYesNo_Id);
                    //model.HeardAboutSolarEYes_IfYeswhere = tbl.HeardAboutSolarEYes_IfYeswhere;
                    //model.InforknowledgeGovtSubsidyOfSEYesNo_Id = Convert.ToInt32(tbl.InforknowledgeGovtSubsidyOfSEYesNo_Id);
                    //model.InforknowledgeIfYesAmtGovPaid = Convert.ToInt32(tbl.InforknowledgeIfYesAmtGovPaid);
                    //model.LoanProcedureInSEYesNo_Id = Convert.ToInt32(tbl.LoanProcedureInSEYesNo_Id);
                    //model.AdoptSolarizationYesNo_Id = Convert.ToInt32(tbl.AdoptSolarizationYesNo_Id);
                    //model.CapitalArrangedForSEYesNo_Id = Convert.ToInt32(tbl.CapitalArrangedForSEYesNo_Id);
                    //model.IfYesCapitalArrangedForSEAmt = Convert.ToInt32(tbl.IfYesCapitalArrangedForSEAmt);
                    //model.OtherIndustriesEnterprisesYesNo_Id = Convert.ToInt32(tbl.OtherIndustriesEnterprisesYesNo_Id);
                    //model.IfYesFillForm_OtherIndustriesEnterprises = tbl.IfYesFillForm_OtherIndustriesEnterprises;
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AddParticipant(Participant model)
        {
            JsonResponseData response = new JsonResponseData();
            try
            {
                //if (ModelState.IsValid)
                //{
                //var existingPart = SPManager.Check_ParticipantAlready(model.Indt_Id.ToString(), model.PhoneNumber, model.AadharNo); //db.Tbl_IndtSolarization.Where(x => x.IsActive == true && x.PhoneNumber == model.PhoneNumber.Trim())?.FirstOrDefault();

                //if (existingPart.Rows.Count > 0)
                //{
                //    response = new JsonResponseData
                //    {
                //        StatusType = eAlertType.error.ToString(),
                //        Message = $"Already Exists Registration.<br /> <span> Reg ID : <strong> {existingPart.Rows[0]["RegNo"].ToString()} </strong>  </span>",
                //        Data = null
                //    };
                //    return Json(response, JsonRequestBehavior.AllowGet);
                //}
                var tbl = model.Indt_Id != Guid.Empty ? db.tbl_IndtSolarization.Find(model.Indt_Id) : new tbl_IndtSolarization();

                if (tbl != null)
                {
                    if (model.Indt_Id == Guid.Empty)
                    {
                        tbl.Indt_Id = Guid.NewGuid();
                    }

                    tbl.StateId = model.StateId;
                    tbl.DistrictId = model.DistrictId;
                    tbl.BlockId = model.BlockId;
                    tbl.PanchayatId = model.PanchayatId;
                    tbl.VillageId = model.VillageId;
                    tbl.CLFId = model.CLFId;
                    tbl.VOId = model.VOId;
                    tbl.AadharNo = model.AadharNo;
                    tbl.DOB = model.DOB;
                    tbl.NameofSHGMember = model.NameofSHGmember?.Trim();
                    tbl.PhoneNumber = model.PhoneNumber?.Trim();
                    tbl.Age = model.Age;
                    tbl.EducationQlf_Id = model.EducationQlf_Id;
                    tbl.YearOfSHG = model.YearOfSHG;
                    tbl.NameofSHG = model.NameofSHG?.Trim();
                    tbl.NameofEnterpriseOwner = model.NameofEnterpriseOwner;
                    tbl.Caste_Id = model.Caste_Id;
                    tbl.TypeofEnterpriseBusin_Id = model.TypeofEnterpriseBusin_Id;
                    tbl.TypeofEnterpriseBusin_Other = model.TypeofEnterpriseBusin_Other;
                    tbl.BusinessOwnedType_Id = model.BusinessOwnedType_Id;
                    tbl.EstablishedEnterpriseType_Id = model.EstablishedEnterpriseType_Id;
                    tbl.TypeOfInvestBusin_Id = model.TypeOfInvestBusin_Id;
                    tbl.TookSourceOfLoan_Id = model.TookSourceOfLoan_Id;
                    tbl.TookLoanAmt = model.TookLoanAmt;

                    tbl.StartBusinessInvestAmt = model.StartBusinessInvestAmt;
                    tbl.StartYourBusinessTakeAmt = model.StartYourBusinessTakeAmt;
                    tbl.MonthlyProfitBusiness = model.MonthlyProfitBusiness;
                    tbl.WorkInEnterprises_FamilyMembers = model.WorkInEnterprises_FamilyMembers;
                    tbl.WorkInEnterprises_SHGMembers = model.WorkInEnterprises_SHGMembers;
                    tbl.WorkInEnterprises_AssitantStaffs = model.WorkInEnterprises_AssitantStaff;
                    tbl.TypeOfMachineEnterprise_Id = model.TypeOfMachineEnterprise_Id;
                    tbl.MotorBasedOnMachinesInActualUsed = model.TypeOfMachineEnterprise_Id;
                    tbl.MachineryPowerkilowatt_Id = model.MachineryPowerkilowatt_Id;
                    tbl.ElectricityConnection_Id = model.ElectricityConnection_Id;
                    tbl.ConnectionPhaseofPower_Id = model.ConnectionPhaseofPower_Id;
                    tbl.MonthlyElectricityConsumption_Id = model.MonthlyElectricityConsumption_Id;
                    tbl.MachineSourceofEnergy_Id = model.MachineSourceofEnergy_Id;
                    tbl.MachineSourceofEnergy_Others = model.MachineSourceofEnergy_Others;
                    tbl.Solar_InKilowatt_Id = model.Solar_InKilowatt_Id;
                    tbl.Solar_EnergyPanelYesNo_Id = model.Solar_EnergyPanelYesNo_Id;
                    tbl.Solar_ExpenditureIncurredAmt = model.Solar_ExpenditureIncurredAmt;
                    tbl.SubsidySolarReceive_Id = model.SubsidySolarReceive_Id;
                    tbl.LoanSolarPanelsYesNo_Id = model.LoanSolarPanelsYesNo_Id;
                    tbl.MonthAvgAmtSavedDescription_Id = model.MonthAvgAmtSavedDescription_Id;
                    tbl.ElectricityUsedHours_Id = model.ElectricityUsedHours_Id;
                    tbl.MonthlyExpenseInElectricityBill_Id = model.MonthlyExpenseInElectricityBill_Id;
                    tbl.GeneratorElectricityUsedHours_Id = model.GeneratorElectricityUsedHours_Id;
                    tbl.MonthlyExpenseFuelSource_Id = model.MonthlyExpenseFuelSource_Id;
                    tbl.MonthlyRepairCost_Id = model.MonthlyRepairCost_Id;
                    tbl.HeardAboutSolarEYesNo_Id = model.HeardAboutSolarEYesNo_Id;
                    tbl.HeardAboutSolarEYes_IfYeswhere = model.HeardAboutSolarEYes_IfYeswhere;
                    tbl.InforknowledgeGovtSubsidyOfSEYesNo_Id = model.InforknowledgeGovtSubsidyOfSEYesNo_Id;
                    tbl.InforknowledgeIfYesAmtGovPaid = model.InforknowledgeIfYesAmtGovPaid;
                    tbl.LoanProcedureInSEYesNo_Id = model.LoanProcedureInSEYesNo_Id;
                    tbl.AdoptSolarizationYesNo_Id = model.AdoptSolarizationYesNo_Id;
                    tbl.CapitalArrangedForSEYesNo_Id = model.CapitalArrangedForSEYesNo_Id;
                    tbl.IfYesCapitalArrangedForSEAmt = model.IfYesCapitalArrangedForSEAmt;
                    tbl.OtherIndustriesEnterprisesYesNo_Id = model.OtherIndustriesEnterprisesYesNo_Id;
                    tbl.IfYesFillForm_OtherIndustriesEnterprises = model.IfYesFillForm_OtherIndustriesEnterprises;
                    tbl.Latitude = model.Latitude;
                    tbl.Longitude = model.Longitude;
                    tbl.Location = model.Location;
                    //image
                    if (!string.IsNullOrWhiteSpace(model.SolarEnterprisePicHd))
                    {
                        var picexterpries = CommonModel.SaveSingleFileBase64string(model.SolarEnterprisePicHd, "Enterprises", tbl.Indt_Id.ToString());
                        tbl.SolarEnterprisePicPath = picexterpries;
                    }

                    tbl.IsActive = true;
                    if (model.Indt_Id == Guid.Empty)
                    {
                        tbl.CreatedBy = User.Identity.Name;
                        tbl.CreatedOn = DateTime.Now;
                        db.tbl_IndtSolarization.Add(tbl);
                    }
                    else
                    {
                        tbl.UpdatedBy = User.Identity.Name;
                        tbl.UpdatedOn = DateTime.Now;
                    }

                    results = db.SaveChanges();
                }

                if (results > 0)
                {
                    response = new JsonResponseData
                    {
                        StatusType = eAlertType.success.ToString(),
                        Message = model.Indt_Id != Guid.Empty
                            ? "Congratulations, you have been updated successfully!"
                            : "Congratulations, you have been successfully registered!",
                        Data = null
                    };
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
                //}
                //else
                //{
                //    response = new JsonResponseData
                //    {
                //        StatusType = eAlertType.error.ToString(),
                //        Message = "All Record Required !!",
                //        Data = null
                //    };
                //    return Json(response, JsonRequestBehavior.AllowGet);
                //}
            }
            catch (Exception ex)
            {
                response = new JsonResponseData
                {
                    StatusType = eAlertType.error.ToString(),
                    Message = "There was a communication error: " + ex.Message,
                    Data = null
                };
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            return View(model);
        }

        public ActionResult ParticipantList()
        {
            return View();
        }
        public ActionResult GetParticipantList()
        {
            DataTable tbllist = SPManager.Get_USP_ParticipantList();
            try
            {
                if (tbllist.Rows.Count > 0)
                {
                    var html = ConvertViewToString("_PData", tbllist);
                    return Json(new { IsSuccess = true, Data = html }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { IsSuccess = false, Data = Enums.GetEnumDescription(Enums.eReturnReg.RecordNotFound) }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { IsSuccess = false, Data = Enums.GetEnumDescription(Enums.eReturnReg.ExceptionError) }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult ParticipantDownload(string Participant = null)
        {
            DataSet participantData = SPManager.USP_PartQAList();
            DataTable dt = participantData.Tables[0];

            if (!string.IsNullOrEmpty(Participant) && Participant.Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    return new HttpStatusCodeResult(404, "No data available for download.");
                }

                using (XLWorkbook QA = new XLWorkbook())
                {
                    QA.Worksheets.Add(dt);
                    QA.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    QA.Style.Font.Bold = true;

                    var DTDAY = DateTime.Now.Date.ToString("dd-MMM-yyyy");
                    HttpContext.Response.Clear();
                    HttpContext.Response.Buffer = true;
                    HttpContext.Response.Charset = "";
                    HttpContext.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    HttpContext.Response.AddHeader("content-disposition", "attachment;filename=ParticipantQAList_" + DTDAY + ".xlsx");

                    try
                    {
                        using (MemoryStream QueAnsDataList = new MemoryStream())
                        {
                            QA.SaveAs(QueAnsDataList);
                            QueAnsDataList.WriteTo(HttpContext.Response.OutputStream);
                            HttpContext.Response.Flush();
                            HttpContext.Response.SuppressContent = true;
                            return new EmptyResult();
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Error generating Excel file: " + ex.Message);
                        return new HttpStatusCodeResult(500, "Error generating Excel file.");
                    }
                }
            }
            return View(dt);
        }
        private string ConvertViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                return sw.GetStringBuilder().ToString();
            }
        }

        private const string GoogleApiKey = "AIzaSyAw2rgDsJqTKA8ern_oI6heqv-xgSLuu1U";

        [HttpGet]
        public async Task<JsonResult> GetAddress(double lat, double lng)
        {
            string apiUrl = $"https://maps.googleapis.com/maps/api/geocode/json?latlng={lat},{lng}&key={GoogleApiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    return Json(jsonData, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { error = "Failed to fetch geocode data." }, JsonRequestBehavior.AllowGet);
                }
            }
        }
    }
}