using Entities;
using GDR.BAL;
using GoogleDriveReplica.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleDriveReplica.Controllers
{
    public class UserController : Controller
    {
       
        [HttpGet]
        public ActionResult Login()
        {
            SessionManager.ClearSession();  // clears the previous session when login action is called.
            if (TempData["EmptyFields"] != null)
            {
                ViewBag.EmptyFields = TempData["EmptyFields"];
            }
            else if (TempData["LoginError"] != null)
            {
                ViewBag.LoginError = TempData["LoginError"];
            }
            ViewBag.LoginId = TempData["LoginId"];
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            if (TempData["EmptyFields"] != null)
            {
                ViewBag.EmptyFields = TempData["EmptyFields"];
            }
            else if (TempData["password-match-error"] != null)
            {
                ViewBag.PasswordMatchError = TempData["password-match-error"];
            }
            else if (TempData["unique-id-error"] != null)
            {
                ViewBag.UniqueIdError = TempData["unique-id-error"];
            }
            ViewBag.UserName = TempData["Name"];
            ViewBag.LoginId = TempData["LoginId"];
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser()
        {
            String userName = Request["user-name"];
            String loginId = Request["user-login-id"];
            String passwd = Request["user-passwd"];
            String confirmPasswd = Request["user-confirm-passwd"];
            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(loginId) || String.IsNullOrEmpty(passwd) || String.IsNullOrEmpty(confirmPasswd))
            {
                TempData["EmptyFields"] = "Fields must not be empty";
                return Redirect("~/User/SignUp");
            }

            if (passwd != confirmPasswd)
            {
                TempData["password-match-error"] = "Password and Confirm password does not match";
                TempData["Name"] = userName;
                TempData["LoginId"] = loginId;
                return Redirect("~/User/SignUp");
            }

            if (UserBO.DoesUserExist(loginId) != 0) // this id is present already.
            {
                TempData["unique-id-error"] = "This username already exists";
                TempData["Name"] = userName;
                TempData["LoginId"] = loginId;
                return Redirect("~/User/SignUp");
            }

            if (UserBO.RegisterUser(loginId, userName, passwd) == 1) // user gets registered.
            {
                // tell user is registered.
                return Redirect("~/User/Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult ValidateUser()
        {
            String login = Request["user-login-name"];
            String password = Request["user-password"];

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                TempData["EmptyFields"] = "Fields must not be empty";
                return Redirect("~/User/Login");
            }
            UserDTO dto = UserBO.ValidateUser(login, password);
            if (dto != null)
            {
                var token = TokenGenerator.JWTHelper.GenerateToken(dto.Login, dto.Password);
                dto.Token = token;
                SessionManager.User = dto;
                TempData["PFolder"] = null;
                return Redirect("~/User/Home");
            }
            else
            {
                TempData["LoginError"] = "Username or Password must be incorrect.";
                TempData["LoginId"] = login;        
                return Redirect("~/User/Login");
            }
        }

        [HttpGet]
        public ActionResult Home()
        {
            if (!SessionManager.IsValidUser)
            {
                return Redirect("~/User/Login");
            }
            ViewBag.ParentFolder = TempData["PFolder"];
            var dto = SessionManager.User;
            ViewBag.Token = dto.Token;
            return View();
        }
    }

}