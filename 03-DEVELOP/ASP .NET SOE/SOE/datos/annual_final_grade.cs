using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class annual_final_grade
    {
        private int id;
        private int final_quarterly_grade_id;
        private int annual_final_gradee;

        public annual_final_grade()
        {

        }

        public annual_final_grade(int id, int final_quarterly_grade_id, int annual_final_gradee)
        {
            this.id = id;
            this.final_quarterly_grade_id = final_quarterly_grade_id;
            this.annual_final_gradee = annual_final_gradee;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Final_quarterly_grade_id
        {
            get { return final_quarterly_grade_id; }
            set { final_quarterly_grade_id = value; }
        }
        public int Annual_final_gradee
        {
            get { return annual_final_gradee; }
            set { annual_final_gradee = value; }
        }
    }
}
