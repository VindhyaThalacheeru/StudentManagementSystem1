using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentCourseRegistration
{
    public class Trainerlist
    {
        public static List<Trainer> lstTrainer = new List<Trainer>();

        public void NewTrainer(Trainer t1)
        {
            lstTrainer.Add(t1);
        }

    }
}