namespace MCC79L;

using System.Data;
using System.Data.SqlClient;

public class Program
{
    //Connection Global
    public static string connectionString = "Data Source=DESKTOP-K75VUCD;Database=db_hr;Integrated Security=True;Connect Timeout=30;";

    public static SqlConnection connection;
    public static void Main(string[] args)
    {   //database connectivity
        connection = new SqlConnection(connectionString);


        menu();

        //get all country
        /*List<Countries> countries = Countries.GetAllCountry();
        foreach (Countries country in countries)
        {
            Console.WriteLine("ID: " + country.Id + ", Name: " + country.Name + ", Region ID: " + country.RegionId);
        }
        Console.WriteLine();*/

      

    }

    static void menu()
    {
        Console.WriteLine("Pilih Menu");
        Console.WriteLine("1. Region");
        Console.WriteLine("2. Country");
        Console.WriteLine("3. Location");
        Console.WriteLine("4. Department");
        Console.WriteLine("5. Employee");
        Console.WriteLine("6. Job");
        Console.WriteLine("7. History");
    
        try
        {
            Console.Write("Menu: ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("1. Get All Region");
                    Console.WriteLine("2. Get Region By ID");
                    Console.WriteLine("3. Insert New Region");
                    Console.WriteLine("4. Update Region");
                    Console.WriteLine("5. Delete Region");
                    Console.WriteLine("6. Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            //get all region
                            List<Region> regions = Region.GetAllRegion();
                            foreach (Region region in regions)
                            {
                                Console.WriteLine("ID: " + region.Id + ", Name: " + region.Name);
                            }
                            Console.WriteLine();
                            break;
                        case 2:
                            //get region by id
                            Console.Write("Masukan ID region: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            List<Region> regionsid = Region.GetRegionByID(id);
                            foreach (Region region in regionsid)
                            {
                                Console.WriteLine("ID: " + region.Id + ", Name: " + region.Name);
                            }
                            Console.WriteLine();
                            break;
                        case 3:
                            //insert region name
                            Console.WriteLine("Insert");
                            Console.Write("Masukan nama region: ");
                            string nama = Console.ReadLine();
                            int isInsertSuccessful = Region.InsertRegion(nama);
                            if (isInsertSuccessful > 0)
                            {
                                Console.WriteLine("Data berhasil ditambahkan!");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Data gagal ditambahkan!");
                            }
                            break;
                        case 4:
                            //update region name
                            Console.Write("Masukan ID region: ");
                            int idReg = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Masukan nama region: ");
                            string namaReg = Console.ReadLine();
                            Region.UpdateRegion(idReg, namaReg);
                            break;
                        case 5:
                            //delete region
                            Console.WriteLine("Masukkan ID Region yang akan dihapus: ");
                            int regionId = Convert.ToInt32(Console.ReadLine());
                            Region.DeleteRegion(regionId);
                            Console.WriteLine("Data Region berhasil dihapus.");
                            Console.ReadKey();

                            /*bool success = Region.DeleteRegionI(regionId, connectionString);

                            if (success)
                            {
                                Console.WriteLine("Data Region berhasil dihapus.");
                            }
                            else
                            {
                                Console.WriteLine("Gagal menghapus data Region.");
                            }*/
                            break;
                        case 6:
                            menu();
                            break;
                        default:
                            Console.WriteLine("Pilihan salah");
                            break;

                    }
                    break;

                case 2:
                    Console.WriteLine("1. Get All Country");
                    Console.WriteLine("2. Get Country By ID");
                    Console.WriteLine("3. Insert New Country");
                    Console.WriteLine("4. Update Country");
                    Console.WriteLine("5. Delete Country");
                    Console.WriteLine("6. Exit");
                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    switch (choice2)
                    {
                        case 1:
                            //get all country
                            List<Countries> countries = Countries.GetAllCountry();
                            foreach (Countries country in countries)
                            {
                                Console.WriteLine("ID: " + country.Id + ", Name: " + country.Name +     ", Region ID: " + country.RegionId);
                            }
                            Console.WriteLine();
                            break;
                        case 2:
                            //get country by id
                            Console.Write("Masukan ID country: ");
                            string id = Console.ReadLine();

                            List<Countries> countryid = Countries.GetCountryByID(id);
                            foreach (Countries country in countryid)
                            {
                                Console.WriteLine("ID: " + country.Id + ", Name: " + country.Name +     ", Region ID: " + country.RegionId);
                            }
                            Console.WriteLine();
                            break;
                        case 3:
                            //insert country
                            Console.WriteLine("Insert");
                            Console.Write("Masukan ID country: ");
                            string idcountry = Console.ReadLine();

                            Console.Write("Masukan nama country: ");
                            string nama = Console.ReadLine();

                            Console.Write("Masukan ID region: ");
                            int idreg = Convert.ToInt32(Console.ReadLine());

                            Countries.InsertCountry(idcountry, nama, idreg);
                            break;
                        case 4:
                            //update country
                            Console.Write("Masukan ID Country yang dicari: ");
                            string updIDC = Console.ReadLine();

                            Console.Write("Masukan nama Country baru: ");
                            string updNameC = Console.ReadLine();

                            Console.Write("Masukan ID Region baru: ");
                            int updIDR = Convert.ToInt32(Console.ReadLine());

                            Countries.UpdateCountry(updIDC, updNameC, updIDR);

                            break;
                        case 5:
                            //delete country
                            Console.WriteLine("Masukkan ID Region yang akan dihapus: ");
                            string countryId = Console.ReadLine();

                            Countries.DeleteCountry(countryId);
                            break;
                        case 6:
                            menu();
                            break;
                        default:
                            Console.WriteLine("Pilihan salah");
                            break;
                    }
                    break;
                case 3:
                    //get all locations
                    List<Locations> locations = Locations.GetAllLocation();
                    foreach (Locations location in locations)
                    {
                        Console.WriteLine("ID: " + location.Id + ", Street Address: " + location.StreetAdrs + ", Postal Code: " + location.Postal + ", City: " + location.City + ", State Province: " + location.State + ", Country ID: " + location.CtrID);
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    //get all departments
                    List<Departments> departments = Departments.GetAllDepartment();
                    foreach (Departments department in departments)
                    {
                        Console.WriteLine("ID: " + department.Id + ", Name: " + department.Name + ", Location ID: " + department.LocationID + ", Manager ID: " + department.ManagerID);
                    }
                    Console.WriteLine();
                    break;
                case 5:
                    //get all employee
                    List<Employees> employees = Employees.GetAllEmployee();
                    foreach (Employees employee in employees)
                    {
                        Console.WriteLine("ID: " + employee.Id + ", First Name: " + employee.firstName + ", Last Name: " + employee.lastName + ", Email: " + employee.email + ", Phone: " + employee.phone + ", Hire date: " + employee.hiredate + ", Salary: " + employee.salary + ", Comission: " + employee.comission + ", Manager ID: " + employee.ManagerID + ", Job ID: " + employee.JobID + ", Department ID: " + employee.DptID);
                    }
                    Console.WriteLine();
                    break;
                case 6:

                    //get all jobs
                    List<Jobs> jobs = Jobs.GetAllJob();
                    foreach (Jobs job in jobs)
                    {
                        Console.WriteLine("ID: " + job.Id + ", Title: " + job.title + ", min salary: " + job.minSalary + ", max salary: " + job.maxSalary);
                    }
                    Console.WriteLine();
                    break;
                case 7:
                    //get all histories
                    List<Histories> histories = Histories.GetAllHistory();
                    foreach (Histories history in histories)
                    {
                        Console.WriteLine("Start Date: " + history.startDate + ", Employee ID: " + history.Id + ", End Date: " + history.endDate + ", department ID: " + history.dptID + ", job ID: " + history.jobID);
                    }
                    Console.WriteLine();

                    break;
                case 8:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pilihan salah");
                    break;

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Pilihan salah");
        }
    }
}

