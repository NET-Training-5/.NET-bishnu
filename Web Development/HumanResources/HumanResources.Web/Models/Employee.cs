﻿using HumanResources.Web.Enums;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Web.Models;
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Address { get; set; }
    
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    
    public Gender Gender { get; set; }
    public DateTime? Dob { get; set; }
    public DateTime JoinDate { get; set; }
    public string Designation { get; set; }

    public Department Department { get; set; }
    public int DepartmentId { get; set; }
}
