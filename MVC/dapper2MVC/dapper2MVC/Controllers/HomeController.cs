using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dapper2MVC.Models;
using dapper2MVC.DAL;

namespace dapper2MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly GroupMeetingService groupMeetingService = new GroupMeetingService();
        private readonly RoomService roomService = new RoomService();
        public IActionResult Index()
        {
            return View(groupMeetingService.GetGroupMeetings());
        }
        public IActionResult Create()
        {
            ViewBag.Rooms = GetRooms();
            return View();
        }

        [HttpPost]
        public IActionResult Create(GroupMeetingCreate model)
        {
            var createResult = groupMeetingService.AddGroupMeeting(new GroupMeeting()
            {
                Description = model.Description,
                GroupMeetingDate = model.GroupMeetingDate,
                GroupMeetingLeadName = model.GroupMeetingLeadName,
                ProjectName = model.ProjectName,
                TeamLeadName = model.TeamLeadName,
                RoomID = model.RoomID
            });
            if (createResult > 0)
            {
                TempData["Success"] = "Group meeting has been created success";
            }
            else
            {
                TempData["Error"] = "Something went wrong, please try again later";
            }
            ModelState.Clear();
            ViewBag.Rooms = GetRooms();
            return View(new GroupMeetingCreate() { GroupMeetingDate = DateTime.Now });
            
        }
        private List<RoomView> GetRooms()
        {
            var response = roomService.GetRooms();
            var data = response.Select(s => new RoomView()
            {
                Name = s.RoomName,
                Value = s.RoomID
            }).ToList();
            return data;
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Delete(int id)
        {
            var group = groupMeetingService.GetGroupMeetingById(id);
            if (group == null)
            {
                return NotFound();
            }
            return View(group);
        }

        [HttpPost]
        public IActionResult Delete(int id, GroupMeetingService groupMeetingService)
        {
            var deleteResult = groupMeetingService.GetGroupMeetingById(id);
            if (groupMeetingService.DeleteGroupMeeting(id) > 0)
            {
                return RedirectToAction("Index");
            }
            return View(groupMeetingService);
        }
        public IActionResult Details(int id)
        {
            var details = groupMeetingService.GetGroupMeetingById(id);
            return View(details);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var group = groupMeetingService.GetGroupMeetingById(id);
            if (group == null)
                return NotFound();
            return View(group);
        }
        [HttpPost]
        public IActionResult Edit(int id, [Bind] GroupMeeting groupMeeting)
        {
            if (id != groupMeeting.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                groupMeetingService.UpdateGroupMeeting(groupMeeting);
                return RedirectToAction("Index");
            }
            return View(groupMeeting);
        }
    }
}
