using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserMembershipApplication.Models;


// This Model Creates a User Entity within Entity Core
// Security unattended


public class User
{
    // The Identity option means that the database will generate a value when a row is inserted
    // SQL Server makes an identity column for an integer property
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public DateTime DateOfBirth { get; set; }

    public string PhoneNumber { get; set; }
    public string AddressFirstLine { get; set; }
    public string AddressSecondLine { get; set; }
    public string AddressCity { get; set; }
    public string PostCode { get; set; }
}