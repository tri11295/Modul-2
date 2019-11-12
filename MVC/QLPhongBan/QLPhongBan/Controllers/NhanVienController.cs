using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLPhongBan.Models.NhanVien;

namespace QLPhongBan.Controllers
{
    public class NhanVienController : Controller
    {
        private static int PhongBanID = 0;
        public IActionResult Index()
        {
            var users = new List<NhanVienView>();
            var url = "https://localhost:44368/api/nhanvien/getall";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }
                users = JsonConvert.DeserializeObject<List<NhanVienView>>(responseData);
            }
            
            return View(users);
        }
        private List<PhongBanItem> DanhSachPhongBan()
        {
            var PhongBan = new List<PhongBanItem>();
            var url = "https://localhost:44368/api/phongban/gets";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }
                PhongBan = JsonConvert.DeserializeObject<List<PhongBanItem>>(responseData);
            }
            return PhongBan;
        }
       
        public IActionResult NhanVien(int id)
        {
            var nhanvien = new List<NhanVienView>();
            var url = "https://localhost:44368/api/nhanvien/getnvbypbid/" + id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }
                nhanvien = JsonConvert.DeserializeObject<List<NhanVienView>>(responseData);
            }
            PhongBanID = id;
            ViewBag.TenPhongBan = DanhSachPhongBan().Where(p => p.ID == id).FirstOrDefault().TenPB;
            return View(nhanvien);
        }

        public IActionResult Create()
        {
            ViewBag.PhongBans = DanhSachPhongBan();
            ViewBag.PhongBanID = PhongBanID;
            TempData["Success"] = null;
            return View();
        }
        [HttpPost]
        public IActionResult Create(NhanVienCreateView model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44368/api/nhanvien/create");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                createResult = bool.Parse(result);
            }
            if (createResult)
            {
                TempData["Success"] = "Nhan Vien has been created successfully";
            }
            ViewBag.PhongBans = DanhSachPhongBan();
            ViewBag.PhongBanID = PhongBanID;
            ModelState.Clear();
            return View(new NhanVienCreateView() { });
        }
        public IActionResult Edit(int id)
        {
            var userEdit = new NhanVienEditView();
            var url = "https://localhost:44368/api/nhanvien/get/" + id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                userEdit = JsonConvert.DeserializeObject<NhanVienEditView>(responseData);
            }

            return View(userEdit);
        }
        [HttpPost]
        public IActionResult Edit(NhanVienEditView model)
        {
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44368/api/nhanvien/update");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                updateResult = bool.Parse(result);
            }
            if (updateResult)
            {
                TempData["Success"] = "User has been update successfully";
            }
            return RedirectToAction("Index", "NhanVien", new { id = model.IDPB });
        }
        public IActionResult Delete(int id)
        {
            var model = new NhanVienDeleteView();
            var deleteResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44368/api/nhanvien/delete/" + id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                deleteResult = bool.Parse(result);
            }
            return RedirectToAction("Index", "PhongBan");
        }
        public IActionResult Details(int id)
        {
            var user = new NhanVienView();
            var url = "https://localhost:44368/api/nhanvien/get/" + id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                user = JsonConvert.DeserializeObject<NhanVienView>(responseData);
            }
            return View(user);
        }
    }
}