﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DergiAboneProje.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace DergiAboneProje.Controllers
{
    [Authorize(Roles = "A")]
    public class AbonelikController : Controller
    {
        DergiDbContext c = new DergiDbContext();
        public IActionResult Liste()
        {
            TempData.Clear();
            var degerler = c.Aboneliklers
                .Include(x => x.Uye)
                .Include(x => x.Dergi)
                .ToList();
            return View(degerler);           
        }
        
       public IActionResult Sil(int id)
        {
            try
            {
                var abn = c.Aboneliklers.Find(id);
                c.Aboneliklers.Remove(abn);
                c.SaveChanges();
                //if (TempData.ContainsKey("UyeKey"))
                //{
                //    return RedirectToAction("Detay", "Uye", new { id = TempData["UyeKey"] });
                //}
                //else if (TempData.ContainsKey("DergiKey"))
                //{
                //    return RedirectToAction("Detay", "Dergi", new { id = TempData["DergiKey"] });
                //}
                //return RedirectToAction("Liste");
            }
            catch
            {

            }
            return NoContent();
        }
        public IActionResult Iptal(int id)
        {
            try
            {
                var abn = c.Aboneliklers.Find(id);
                abn.KayıtSuresi =  abn.KayıtSuresi - (abn.KayıtTarihi.AddDays(abn.KayıtSuresi) - DateTime.Now).Days;
                c.Aboneliklers.Update(abn);
                c.SaveChanges();
                //if (TempData.ContainsKey("UyeKey"))
                //{
                //    return RedirectToAction("Detay", "Uye", new { id = TempData["UyeKey"] });
                //}
                //else if (TempData.ContainsKey("DergiKey"))
                //{
                //    return RedirectToAction("Detay", "Dergi", new { id = TempData["DergiKey"] });
                //}
                //return RedirectToAction("Liste");
            }
            catch
            {
                
            }
            return NoContent();
        }
        public void getUye_DergiIDsList()
        {
            List<SelectListItem> _uyeID = (from x in c.Uyelers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = "(" + x.UyeID.ToString() + ") " + x.UyeAD,
                                               Value = x.UyeID.ToString()
                                           }).ToList();
            ViewBag.UyeID = _uyeID;
            List<SelectListItem> _dergiID = (from x in c.Dergilers.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = "(" + x.DergiID.ToString() + ") " + x.DergiAD,
                                                 Value = x.DergiID.ToString()
                                             }).ToList();
            ViewBag.DergiID = _dergiID;
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            getUye_DergiIDsList();
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Abonelikler b)
        {
            b.KayıtSuresi *= 30;
            var ActiveAbonelik = c.Aboneliklers.Where(x => x.UyeID == b.UyeID && x.DergiID == b.DergiID && x.KayıtTarihi.AddDays(x.KayıtSuresi - 2).Date >= DateTime.Now.Date);
            var CheckActiveAbonelik = ActiveAbonelik.Count() != 0;           
            if (CheckActiveAbonelik)
            {
                var IDActiveAbonelik = ActiveAbonelik.FirstOrDefault().KayıtID;
                ModelState.AddModelError("CheckActiveAbonelik", "Bu üyenin bu dergiye zaten aktif bir üyeliği var. Abonelik ID: " + IDActiveAbonelik);
            }
           
            else if (ModelState.IsValid)
            {
                
                try
                {
                    c.Aboneliklers.Add(b);
                    c.SaveChanges();
                    return RedirectToAction("Liste");
                }
                catch
                {

                }

            }
            getUye_DergiIDsList();
            return View();


        }
      
        [HttpGet]
        public IActionResult Duzenle(int id)
        {
            getUye_DergiIDsList();
            
            var abone = c.Aboneliklers.Find(id);
            ViewBag.KayıtTarihi = abone.KayıtTarihi.ToShortDateString();
            ViewBag.KayıtID = id;
            abone.KayıtSuresi /= 30;
            return View("Duzenle", abone);
        }
        [HttpPost]
        public IActionResult Duzenle(Abonelikler b)
        {
            b.KayıtSuresi *= 30;
            var ActiveAbonelik = c.Aboneliklers.Where(x => x.UyeID == b.UyeID && x.DergiID == b.DergiID && x.KayıtID != b.KayıtID && x.KayıtTarihi.AddDays(x.KayıtSuresi - 2).Date >= DateTime.Now.Date);
            var CheckActiveAbonelik = ActiveAbonelik.Count() != 0;
            var ChangesNotMade = c.Aboneliklers.Where(x => x.KayıtID == b.KayıtID && x.KayıtSuresi == b.KayıtSuresi && x.DergiID == b.DergiID && x.UyeID == b.UyeID).Count() != 0;
            if (CheckActiveAbonelik)
            {
                var IDActiveAbonelik = ActiveAbonelik.FirstOrDefault().KayıtID;
                ModelState.AddModelError("CheckActiveAbonelik", "Bu üyenin bu dergiye zaten aktif bir üyeliği var. Abonelik ID: " + IDActiveAbonelik);
            }
            if (ChangesNotMade)
            {
                ModelState.AddModelError("!ChangesMade", "Düzenleme yapmadınız.");
            }
            else if (ModelState.IsValid)
            {
                try
                {
                    
                    c.Aboneliklers.Update(b);
                    c.SaveChanges();
                    return RedirectToAction("Liste");
                }
                catch
                {

                }
            }
            ViewBag.KayıtTarihi = b.KayıtTarihi.ToShortDateString();
            ViewBag.KayıtID = b.KayıtID;
            getUye_DergiIDsList();
            return View();
        }
    }
}
