using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Id = 1,
                ModelYear = 2018,
                DailyPrice = 400,
                Description = "A5 Cabrio",
                BrandId = 1,
                ColorId = 1002
            };
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            
            //-----------------------RentalManager CRUD Testleri--------------------------------
            //RentalDeletedTest(rentalManager);
            //RentalUpdateTest(rentalManager);
            RentalAddTest(rentalManager);
            //RentalGetByIdTest(rentalManager);
            //RentalGetAllTest(rentalManager);

            //-----------------------UserManager CRUD Testleri--------------------------------
            //UserDeletedTest(userManager);
            //UserUpdateTest(userManager);
            //UserAddTest(userManager);
            //UserGetByIdTest(userManager);
            //UserGetAllTest(userManager);


            //-----------------------CustomerManager CRUD Testleri--------------------------------
            //CustomerDeletedTest(customerManager);
            //CustomerUpdateTest(customerManager);
            //CustomerAddTest(customerManager);
            //CustomerGetByIdTest(customerManager);
            //CustomerGetAllTest(customerManager);

            //-----------------------UserManager CRUD Testleri--------------------------------
            //colorManager.Delete(new Color { Id = 2002, ColorName = "Orange" });
            //colorManager.Update(new Color { Id=2,ColorName="Orange"});
            //colorManager.Add(new Color { ColorName="Lila"});
            //ColorGetByIdTest(colorManager);
            //ColorGetAllTest(colorManager);


            //-----------------------BrandManager CRUD Testleri--------------------------------
            //brandManager.Update(new Brand {Id=1005,BrandName="Opel" });
            //brandManager.Delete(new Brand { Id = 1004 });
            //brandManager.Add(new Brand { BrandName = "Volkswagen" });
            //BrandGetByIdTest(brandManager);
            // BrandGetAll(brandManager);

            //-----------------------CarManager CRUD Testleri--------------------------------
            //carManager.Update(car1);
            //carManager.Delete(car1);
            //carManager.Add(car1);
            //ColorIdFilterTest(carManager);
            //BrandIdFilterTest(carManager);
            //ModelYearFilterTest(carManager);
            //CarDetailTest(carManager);
            //CarGetAllTest(carManager);
        }
        


        //-------------------------------Rental Methods------------------------------------

        private static void RentalDeletedTest(RentalManager rentalManager)
        {
            //for (int i = 11; i < 16; i++)
            //{
            //    var result = rentalManager.Delete(new Rental { RentalId = i });
            //}
            var result = rentalManager.Delete(new Rental { RentalId = 3 });
            Console.WriteLine(result.Message);
        }

        private static void RentalUpdateTest(RentalManager rentalManager)
        {
            var result = rentalManager.Update(new Rental { RentalId = 1, 
                ReturnDate =new  DateTime(2021,3,25) });
            Console.WriteLine(result.Message);
        }

        private static void RentalAddTest(RentalManager rentalManager)
        {
            

            var result = rentalManager.Add(new Rental
            {
                CustomerId =5,               
                CarId = 2,
                RentDate = new DateTime(2021,3,31),
                ReturnDate = new DateTime(2021,3,27)
            });
            Console.WriteLine(result.Message);
        }    

        private static void RentalGetAllTest(RentalManager rentalManager)
        {
            var result = rentalManager.GetAll();
            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CustomerId+" " + rental.RentDate + " " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalGetByIdTest(RentalManager rentalManager)
        {
            var result = rentalManager.GetById(4);
            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CustomerId + " " + rental.RentDate + " " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //-------------------------------User Methods------------------------------------


        private static void UserDeletedTest(UserManager userManager)
        {
            var result = userManager.Delete(new User { UserId = 6 });
            Console.WriteLine(result.Message);
        }

        private static void UserUpdateTest(UserManager userManager)
        {
            var result = userManager.Update(new User { UserId = 7, FirstName = "Aslan" });
            Console.WriteLine(result.Message);
        }

        private static void UserAddTest(UserManager userManager)
        {
            var result = userManager.Add(new User
            {
                FirstName = "Yunus",
                LastName = "Akalp",
                Password = "1234ya",
                Email = default
            });
            Console.WriteLine(result.Message);
        }
        

        private static void UserGetAllTest(UserManager userManager)
        {
            var result = userManager.GetAll();
            if (result.Success == true)
            {
                foreach (var u in result.Data)
                {
                    Console.WriteLine(u.FirstName+" "+u.LastName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserGetByIdTest(UserManager userManager)
        {
            var result = userManager.GetById(4);
            if (result.Success == true)
            {
                foreach (var u in result.Data)
                {
                    Console.WriteLine(u.FirstName + " " + u.LastName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        //-------------------------------Customer Methods------------------------------------


        private static void CustomerDeletedTest(CustomerManager customerManager)
        {
            var result = customerManager.Delete(new Customer { UserId = 3 });
            Console.WriteLine(result.Message);
        }

        private static void CustomerUpdateTest(CustomerManager customerManager)
        {
            var result = customerManager.Update(new Customer { CustomerId = 4,UserId=5, CompanyName = "Aslanlar holding" });
            Console.WriteLine(result.Message);
        }

        private static void CustomerAddTest(CustomerManager customerManager)
        {
            var result = customerManager.Add(new Customer
            {
                UserId = 4,
                CompanyName = "Leylaklar Holding"
            });
            Console.WriteLine(result.Message);
        }
        private static void CustomerGetAllTest(CustomerManager customerManager)
        {
            var result = customerManager.GetAll();
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.CustomerId + " " + c.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerGetByIdTest(CustomerManager customerManager)
        {
            var result = customerManager.GetById(4);
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.CustomerId + " " + c.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        //-------------------------------Color Methods------------------------------------


        private static void ColorGetByIdTest(ColorManager colorManager)
        {
            var result = colorManager.GetById(4);
            if (result.Success == true)
            {
                foreach (var r in result.Data)
                {
                    Console.WriteLine(r.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void ColorGetAllTest(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var r in result.Data)
                {
                    Console.WriteLine(r.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        //-------------------------------Brand Methods------------------------------------


        private static void BrandGetByIdTest(BrandManager brandManager)
        {
            var result = brandManager.GetById(1);
            if (result.Success == true)
            {
                foreach (var b in result.Data)
                {
                    Console.WriteLine(b.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var b in result.Data)
                {
                    Console.WriteLine(b.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }            
        }
        //-------------------------------Car Methods------------------------------------

        private static void ColorIdFilterTest(CarManager carManager)
        {
            var result = carManager.GetCarsByColorId(3);
            if (result.Success==true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }

        private static void BrandIdFilterTest(CarManager carManager)
        {
            var result = carManager.GetCarsByBrandId(2);
            if (result.Success==true)
            {
                foreach (var c in result.Data )
                {
                    Console.WriteLine(c.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }

        private static void ModelYearFilterTest(CarManager carManager)
        {
            var result = carManager.GetByModelYear(2010, 2016);
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.ModelYear);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetailTest(CarManager carManager)
        {
            var result = carManager.GetCarDetail();
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.BrandName + " " + c.Description
                    + " " + c.ModelYear + " " + c.ColorName
                    + " " + c.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarGetAllTest(CarManager carManager)
        {
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }           
        }
    }
}
