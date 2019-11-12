using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Dapper;
using DAPPER_QLTV.Models;
using DAPPER_QLTV.Models.ChonSach;
using DAPPER_QLTV.Models.SachMuon;
using DAPPER_QLTV.Models.TaiKhoan;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DAPPER_QLTV.Controllers
{   
    public class TaiKhoanController : Controller
    {
        public static int IDPhieuMuon = 0;
        public static string MaPhieuMuon;
        public static int IDTaiKhoan = 0;
        public static int IDTKSM = 0;
        public static int dem = 0;
        public IActionResult Index()
        {
            var users = new List<TaiKhoanView>();
            var url = "http://localhost:51479/api/taikhoan/gets";
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
                users = JsonConvert.DeserializeObject<List<TaiKhoanView>>(responseData);
            }
            return View(users);
        }
        public IActionResult ChonSach(int id)
        {
            var users = new List<ChonSach>();
            var url = "http://localhost:51479/api/muonsach/chonsach/" + id;
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
                users = JsonConvert.DeserializeObject<List<ChonSach>>(responseData);
            }
            ViewBag.IDPhieuMuon = IDPhieuMuon;
            ViewBag.IDTaiKhoan = IDTaiKhoan;
            if(dem>5)
            {
                TempData["Success"] = "User has been created successfully";
                return RedirectToAction("XemSachMuonTheoIDPM", "TaiKhoan");
            }
           
            return View(users);            
        }
        public IActionResult XemSachMuonTheoIDPM(int id)
        {
            var users = new List<XemSachMuon>();
            var url = "http://localhost:51479/api/muonsach/getsm/" + id;
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
                users = JsonConvert.DeserializeObject<List<XemSachMuon>>(responseData);
            }
            ViewBag.IDTaiKhoan = IDTaiKhoan;
            ViewBag.IDPM = IDPhieuMuon;
            return View(users);
        }
        public IActionResult ThemSachMuon()
        {
            var SachList = new List<ThemSachMuon>();
            var url = "http://localhost:51479/api/sach/gets";
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
                SachList = JsonConvert.DeserializeObject<List<ThemSachMuon>>(responseData);
            }
            ViewBag.IDPhieuMuon = IDPhieuMuon;
            return View(SachList);
        }

        public IActionResult XemSachMuonTheoIDTK(int id)
        {
            var users = new List<TaiKhoanSachMuon>();
            var url = "http://localhost:51479/api/taikhoan/getsachmuon/" + id;
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
                users = JsonConvert.DeserializeObject<List<TaiKhoanSachMuon>>(responseData);
            }
            ViewBag.IDPhieuMuon = IDPhieuMuon;
            ViewBag.IDTaiKhoan = id;
            IDTKSM = id;
            return View(users);
        }       
                       
        public IActionResult TaoSachMuon(TaoSachMuon model,int id)
        {
            model.IDPhieuMuon = IDPhieuMuon;
            //model.SoLuongMuon = 1;
            ViewBag.MaPhieuMuon = MaPhieuMuon;
            ViewBag.id = IDPhieuMuon;
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51479/api/muonsach/createsm/" + id);
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
                TempData["Success"] = "User has been created successfully";
            }
            ModelState.Clear();
            dem = +1;
            return RedirectToAction("ChonSach", "TaiKhoan",new {id = IDTaiKhoan });
        }        

        public IActionResult TaoPhieuMuon()
        {
            
            TempData["Success"] = null;            
            return View();
        }
        [HttpPost]
        public IActionResult TaoPhieuMuon(TaoPhieuMuon model)
        {
            var createResult = 0;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51479/api/muonsach/createpm");
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
                createResult = int.Parse(result);
            }
            if (createResult>0)
            {
                TempData["Success"] = "User has been created successfully";
            }
            ModelState.Clear();
            IDPhieuMuon = createResult;
            MaPhieuMuon = model.MaPhieuMuon;
            IDTaiKhoan = model.IDTaiKhoan;
            return RedirectToAction("XemSachMuonTheoIDPM", "TaiKhoan", new { id = createResult });            
        }       
       


        public IActionResult Edit(int id)
        {
            var userEdit = new TaiKhoanUpdate();
            var url = "http://localhost:51479/api/taikhoan/get/" + id;
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

                userEdit = JsonConvert.DeserializeObject<TaiKhoanUpdate>(responseData);
            }
            return View(userEdit);
        }

        [HttpPost]
        public IActionResult Edit(TaiKhoanUpdate model)
        {
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51479/api/taikhoan/update");
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
            return RedirectToAction("Index", "TaiKhoan", new { id = model.ID });
        }
        public IActionResult Delete(TaiKhoanDelete model)
        {
            
            var deleteResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51479/api/taikhoan/delete");
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
            return RedirectToAction("Index", "TaiKhoan");
        }
      
        public IActionResult TraSach(int IDSach,int IDPM)
        {         
            
            using (IDbConnection con = new SqlConnection(@"Data Source=TRI;Initial Catalog=QLThuVien;Integrated Security=True"))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDPhieuMuon", IDPM);
                parameters.Add("IDSach", IDSach);                
                SqlMapper.Execute(con, "TraSach", param: parameters, commandType: CommandType.StoredProcedure);
            }
            return RedirectToAction("XemSachMuonTheoIDTK", "TaiKhoan", new { id = IDTKSM });
        }

        public IActionResult HuyMuonSach(int IDSach, int IDPM)
        {            
            using (IDbConnection con = new SqlConnection(@"Data Source=TRI;Initial Catalog=QLThuVien;Integrated Security=True"))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDPhieuMuon", IDPM);
                parameters.Add("IDSach", IDSach);
                SqlMapper.Execute(con, "HuyMuonSach", param: parameters, commandType: CommandType.StoredProcedure);
            }
            return RedirectToAction("XemSachMuonTheoIDPM", "TaiKhoan", new { id = IDPhieuMuon });
        }
        public IActionResult Details(int id)
        {
            var user = new TaiKhoanDetails();
            var url = "http://localhost:51479/api/taikhoan/get/" + id;
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

                user = JsonConvert.DeserializeObject<TaiKhoanDetails>(responseData);
            }
            return View(user);
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
      
    }
}