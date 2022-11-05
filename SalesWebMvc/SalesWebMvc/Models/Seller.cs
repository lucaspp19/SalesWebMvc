using System;
using System.Collections.Generic;
using System.Linq;



namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthData { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> sales = new List<SalesRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthData, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthData = birthData;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSales(SalesRecord sr)
        {
            sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            sales.Remove(sr);
        }
        public double TotalSales1(DateTime initial, DateTime final)
        {

            return sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);

        }
    }
}
