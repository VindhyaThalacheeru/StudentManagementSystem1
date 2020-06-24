using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseRegistration
{
    public class Trainer
    {
        private long _trainerId;
        private string _trainerName;
        private string _email;
        private string _phoneNo;
        private string _country;
        private string _trainerUserName;
        private string _trainerPassword;
        public Trainer(long trainerId, string trainerName, string email, string phoneNo, string country, string trainerUserName, string trainerPassword)
        {
            _trainerId = trainerId;
            _trainerName = trainerName;
            _email = email;
            _phoneNo = phoneNo;
            _country = country;
            _trainerUserName = trainerUserName;
            _trainerPassword = trainerPassword;

        }
        public Trainer()
        {

        }

        public long TrainerId
        {
            get => _trainerId;
            set => _trainerId = value;
        }
        public string TrainerName
        {
            get => _trainerName;
            set => _trainerName = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string PhoneNo
        {
            get => _phoneNo;
            set => _phoneNo = value;
        }
        public string Country
        {
            get => _country;
            set => _country = value;
        }
        public string TrainerUserName
        {
            get => _trainerUserName;
            set => _trainerUserName = value;
        }
        public string TrainerPassword
        {
            get => _trainerPassword;
            set => _trainerPassword = value;
        }
        public Dictionary<long, long> coursesAssociatedwith = new Dictionary<long, long>();
        public void DisplayTrainerDetails(long trainerId)
        {

            foreach (var trainer in Trainerlist.lstTrainer)
            {
                if (trainer.TrainerId == trainerId)
                {

                    Console.WriteLine("Name :" + trainer.TrainerName);
                    Console.WriteLine("Email :" + trainer.Email);
                    Console.WriteLine("PhoneNumber :" + trainer.PhoneNo);
                    Console.WriteLine("Country :" + trainer.Country);
                    Console.WriteLine("COURSES TAGGED TO : \n");

                    foreach (var course in trainer.coursesAssociatedwith)
                    {
                        foreach (var courses in Courselist.lstCourses)
                        {
                            if (courses.CourseId == course.Key)
                            {
                                Console.WriteLine("Course ID :" + courses.CourseId);
                                Console.WriteLine("Course Name :" + courses.CourseName);
                                Console.WriteLine("Course Detail :" + courses.CourseDetail);
                                Console.WriteLine("Course Duration :" + courses.Duration);
                                Console.WriteLine("Course Fees :" + courses.Fees);
                            }
                        }
                    }

                    Console.WriteLine("DO YOU WANT TO TEACH ANY COURSE :");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Program p4 = new Program();
                        p4.SelectCourseToTeach(trainerId);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                }
            }
        }

    }
}