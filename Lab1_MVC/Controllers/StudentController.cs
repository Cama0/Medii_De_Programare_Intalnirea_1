using Lab1_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1_MVC.Controllers;

public class StudentController : Controller
{
    public IActionResult Info()
    {
        var student = new Student { Name = "Ana", Age = 21 };
        return View(student);
    }
}