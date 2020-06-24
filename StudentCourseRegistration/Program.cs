using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseRegistration
{
    public class Program
    {
        Connected cons = new Connected();
        DisconnectedSample dis = new DisconnectedSample();
        Studentlist sl = new Studentlist();
        Courselist cl = new Courselist();
        Trainerlist tl = new Trainerlist();
        Adminlist al = new Adminlist();
        public static void Main(string[] args)
        {
            Course1 cour = new Course1(Admin.CourseID++, "Java", "CoreJava", "120 hours", "600");

            Courselist.lstCourses.Add(cour);

            Trainer train = new Trainer(Admin.TrainerId++, "Netra", "Netra125@gmail.com", "9789456971", "India", "Netra", "PasswordNetra1");

            Trainerlist.lstTrainer.Add(train);

            Program program = new Program();
            program.UserLogin();
        }
        public void UserLogin()
        {

            int choice;
            string username, pswrd;
            Console.WriteLine("WELCOME TO STUDENT COURSE REGISTRATION");
            Console.WriteLine("1. Do you want to login \n2.Sign up as student");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("ENTER CHOICES");
                Console.WriteLine("1. As Student \n2. As Trainer \n3. As Admin");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Username");
                        username = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        pswrd = Console.ReadLine();
                        int count = Studentlist.lststudent.Where(s => s.UserName == username && s.Password == pswrd).Count();

                        if (count != 1)
                        {
                            Console.WriteLine("Enter correct Username and Password.");
                        }
                        else
                        {
                            long studentid = 0;
                            foreach (var objstudent in Studentlist.lststudent)
                            {
                                if (objstudent.UserName == username && objstudent.Password == pswrd)
                                {
                                    studentid = objstudent.StudentId;
                                    objstudent.DisplayStudentDetails(objstudent.StudentId);
                                }
                            }
                            studentFlow(studentid);
                        }

                        break;
                    case 2:
                        Console.WriteLine("Enter Username");
                        username = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        pswrd = Console.ReadLine();
                        count = Trainerlist.lstTrainer.Where(s => s.TrainerUserName == username && s.TrainerPassword == pswrd).Count();

                        if (count != 1)
                        {
                            Console.WriteLine("Enter correct Username and Password.");
                        }
                        else
                        {

                            foreach (var objTrainer in Trainerlist.lstTrainer)
                            {
                                if (objTrainer.TrainerUserName == username && objTrainer.TrainerPassword == pswrd)
                                {
                                    Trainer objTrainer1 = new Trainer();
                                    objTrainer1.DisplayTrainerDetails(objTrainer.TrainerId);
                                }
                            }
                        }

                        break;
                    case 3:
                        Console.WriteLine("Enter Username");
                        username = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        pswrd = Console.ReadLine();
                        if (username == "MainAdmin" && pswrd == "Password1!")
                        {
                            AdminFlow();
                        }
                        else
                        {
                            Console.WriteLine("Enter correct Username and Password.");
                        }

                        break;
                }
            }
            else if (choice == 2)
            {
                Program pro = new Program();
                pro.RegisterStudent();
            }
        }



        public static void AdminFlow()
        {

            Courselist cl1 = new Courselist();
            //cl1.DisplayAllCourses();
            Connected cons2 = new Connected();
            cons2.ReadData();
            Admin ad1 = new Admin();
            ad1.DisplayAllTrainers();
            Program pr3 = new Program();


            //add do while loop for multiple enrollments
            Console.WriteLine("DO YOU WANT TO ENROLL");
            Console.WriteLine("1. Trainer \n2. Course \n3.UpdateCourse");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                pr3.RegisterTrainer();
            }
            else if (choice == 2)
            {
                Console.WriteLine("ENTER COURSE DETAILS");
                Course1 c1 = new Course1();
                Connected cons1 = new Connected();
                long i = cons1.Count() + 1;

                Console.WriteLine("Enter CourseName :");
                string s = Console.ReadLine();

                Console.WriteLine("Enter CourseDetail :");
                string s1 = Console.ReadLine();

                Console.WriteLine("Enter Duration :");
                string s2 = Console.ReadLine();

                Console.WriteLine("Enter Fees :");
                string s3 = Console.ReadLine();
                Course1 cours = new Course1(i, s, s1, s2, s3);

                //Courselist.lstCourses.Add(cours);
                cons1.CreateData(cours);
            }
            else if (choice == 3)
            {
                Program p = new Program();
                p.UpdateFees();
            }

            Console.WriteLine("REGISTERED SUCCESSFULLY.");
            Console.Read();

        }

        private void studentFlow(long studentId)
        {

            Console.WriteLine("Press any key to exit the process...");
            Console.Read();

        }
        public void RegisterStudent()
        {

            Console.WriteLine("ENTER STUDENT DETAILS \n");

            long i = 0;

            Console.WriteLine("Enter Name :");
            string s = Console.ReadLine();

            Console.WriteLine("Enter Email :");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter Phonenumber :");
            string s2 = Console.ReadLine();

            Console.WriteLine("Enter Country :");
            string s3 = Console.ReadLine();

            Console.WriteLine("Enter UserName :");
            string s4 = Console.ReadLine();

            Console.WriteLine("Enter Password :");
            string s5 = Console.ReadLine();
            Student stu = new Student(i, s, s1, s2, s3, s4, s5);
            sl.AddStudent(stu);

            Console.WriteLine("LOGIN TO ENROLL COURSES \n");
            UserLogin();
        }


        public void RegisterTrainer()
        {

            Console.WriteLine("ENTER TRAINER DETAILS");
            Trainer t1 = new Trainer();
            long i = t1.TrainerId + 1;

            Console.WriteLine("Enter Name :");
            string s = Console.ReadLine();

            Console.WriteLine("Enter Email :");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter Phonenumber :");
            string s2 = Console.ReadLine();

            Console.WriteLine("Enter Country :");
            string s3 = Console.ReadLine();

            Console.WriteLine("Enter LoginId :");
            string s4 = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string s5 = Console.ReadLine();
            Trainer objTrainer = new Trainer(i, s, s1, s2, s3, s4, s5);
            tl.NewTrainer(objTrainer);
            Console.WriteLine("PROVIDE DETAILS FOR TRAINER FOR LOGIN \n");
            Trainerlist.lstTrainer.Add(objTrainer);
            Program pr2 = new Program();
            pr2.UserLogin();

        }
        public void UpdateFees()
        {
            Console.WriteLine("Enter the CourseId: ");
            int cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Fees: ");
            string fees = Console.ReadLine();
            cons.UpdateData(fees, cid);
            AdminFlow();
        }



        public void SelectCourseToTeach(long trainerId)
        {
            Student objstu = new Student();
            Console.WriteLine("ENTER VALID COURSE ID THAT YOU WANT TO ENROLL\n");
            //Courselist cl1 = new Courselist();
            Boolean Course1 = cons.ReadData();
            //cl1.DisplayAllCourses();
            int CourseID = Convert.ToInt32(Console.ReadLine());
            //int check = Courselist.CheckForCourse(CourseID);
            Boolean check = cons.Course1Data(CourseID);

            if (check is true)
            {
                foreach (var obj in Trainerlist.lstTrainer)
                {
                    if (obj.TrainerId == trainerId)
                    {
                        obj.coursesAssociatedwith.Add(CourseID, trainerId);
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid Course ID");
                SelectCourseToTeach(trainerId);
            }
            Console.WriteLine("Press any key to exit the process...");
            Console.Read();

        }

    }
}