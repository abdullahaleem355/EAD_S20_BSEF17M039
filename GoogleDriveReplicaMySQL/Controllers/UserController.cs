using Entities;
using GDR.BAL;
using GoogleDriveReplicaMySQL.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleDriveReplicaMySQL.Controllers
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
            if (UserBO.ValidateUser(login, password))
            {
                UserDTO dto = new UserDTO();
                dto.Login = login;
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
            return View();
        }

        [HttpPost]
        public JsonResult FolderInfo()
        {
            if (SessionManager.IsValidUser)
            {
                if (Request["action"] == "getFolderNames")
                {
                    String PfName = null;
                    if (Request["p-folder"] != null)
                        PfName = Request["p-folder"];
                    List<FolderDTO> folderlist = FolderBO.GetChildFolders(PfName);
                    if (String.IsNullOrEmpty(PfName))
                    {
                        var data = new
                        {
                            id = 0,
                            folderlist
                        };
                        return Json(data, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        var data = new
                        {
                            id = PfName,
                            folderlist
                        };
                        return Json(data, JsonRequestBehavior.AllowGet);
                    }

                }

                else if (Request["action"] == "createFolder")
                {
                    if (String.IsNullOrEmpty(Request["new-folder-name"]))
                    {
                        var error = new
                        {
                            errorMsg = "Folder name is mandatory!"
                        };
                        return Json(error, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        String FolderName = Request["new-folder-name"];
                        String PFolder = Request["p-folder"];
                        FolderDTO dto = FolderBO.CreateFolder(FolderName, PFolder);
                        if (dto.FolderID == -1) // if already exists, id must have -1.
                        {
                            var error = new
                            {
                                errorMsg = "Folder name must be unique!"
                            };
                            return Json(error, JsonRequestBehavior.AllowGet);
                        }

                        var data = new
                        {
                            id = dto.FolderID,
                            newfoldername = dto.FolderName
                        };
                        return Json(data, JsonRequestBehavior.AllowGet);
                    }
                }
                return Json("Invalid hit", JsonRequestBehavior.AllowGet);

            }
            else
                return Json("Un-authorized hit! (No User logged in).", JsonRequestBehavior.AllowGet);
        }
    }
}