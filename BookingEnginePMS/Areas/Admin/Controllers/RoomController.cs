using BookingEnginePMS.Business;
using BookingEnginePMS.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingEnginePMS.Areas.Admin.Controllers
{
    public class RoomController : SercurityController
    {
        RoomService roomService = new RoomService();
        // GET: Admin/Room
        public ActionResult Index()
        {
            if (!CheckSecurity(40))
                return Redirect("/Admin/Login/Index");

            int LanguageId = (int)Session["LanguageId"];
            int HotelId = (int)Session["HotelId"];
            using (var connection = DB.ConnectionFactory())
            {
                List<TransitionLanguage> transitions = connection.Query<TransitionLanguage>("TransitionLanguage_Get_Screen_Setting",
                       new
                       {
                           languageId = LanguageId,
                           screenId = 40
                       }, commandType: CommandType.StoredProcedure).ToList();
                Session["transitions"] = transitions;
                return View();
            }
        }
        public ActionResult Clean()
        {
            if (!CheckSecurity())
                return Redirect("/Admin/Login/Index");

            int LanguageId = (int)Session["LanguageId"];
            int HotelId = (int)Session["HotelId"];
            using (var connection = DB.ConnectionFactory())
            {
                List<TransitionLanguage> transitions = connection.Query<TransitionLanguage>("TransitionLanguage_Get_Screen",
                       new
                       {
                           languageId = LanguageId,
                           screenId = 24
                       }, commandType: CommandType.StoredProcedure).ToList();
                Session["transitions"] = transitions;
                return View();
            }
        }
        public JsonResult Get(int RoomTypeId)
        {
            if (!CheckSecurity())
                return Json("", JsonRequestBehavior.AllowGet);

            int hotelId = (int)Session["HotelId"];

            return Json(this.roomService.Get(hotelId, RoomTypeId), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetClean(int roomTypeId, int status)
        {
            if (!CheckSecurity())
                return Json("", JsonRequestBehavior.AllowGet);

            int hotelId = (int)Session["HotelId"];

            return Json(this.roomService.GetClean(hotelId, roomTypeId, status), JsonRequestBehavior.AllowGet);
        }
        public JsonResult ChangeStatusRoom(int roomId, int status)
        {
            if (!CheckSecurity())
                return Json("", JsonRequestBehavior.AllowGet);

            int hotelId = (int)Session["HotelId"];
            this.roomService.ChangeStatusRoom(hotelId, roomId, status);
            return Json(1, JsonRequestBehavior.AllowGet);
        }
        public JsonResult CleanAll()
        {
            if (!CheckSecurity())
                return Json("", JsonRequestBehavior.AllowGet);

            int hotelId = (int)Session["HotelId"];
            this.roomService.CleanAllRoom(hotelId);
            return Json(1, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Detail(int id)
        {
            if (!CheckSecurity())
                return Json("", JsonRequestBehavior.AllowGet);

            int hotelId = (int)Session["HotelId"];
            return Json(this.roomService.GetById(hotelId, id), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Post(Domain.Room room)
        {
            if (!CheckSecurity())
                return Json("", JsonRequestBehavior.AllowGet);

            int hotelId = (int)Session["HotelId"];
            var result = this.roomService.Insert(hotelId, room);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Put(Domain.Room room)
        {
            if (!CheckSecurity())
                return Json("", JsonRequestBehavior.AllowGet);

            int hotelId = (int)Session["HotelId"];
            this.roomService.Update(hotelId, room.RoomId, room);
            return Json(1, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int id)
        {
            if (!CheckSecurity())
                return Json("", JsonRequestBehavior.AllowGet);

            int hotelId = (int)Session["HotelId"];
            this.roomService.DeleteById(hotelId, id);
            return Json(1, JsonRequestBehavior.AllowGet);
        }

    }
}