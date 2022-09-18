// See https://aka.ms/new-console-template for more information
using CustomerManagerForCoffeShop.Abstract;
using CustomerManagerForCoffeShop.Adapter;
using CustomerManagerForCoffeShop.Concrete;
using CustomerManagerForCoffeShop.Entities;

Console.WriteLine("Hello, World!");
BaseCustomerManager customerManager=new NeroCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer { DateOfBirth=new DateTime(1999,1,4),FirstName="Emre",Id=1,LastName="Kocyatagi",NationaltylId="51460032988"});
