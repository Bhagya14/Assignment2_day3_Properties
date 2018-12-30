using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task_day3
{
    class employee
    {
        private int emp_id;
        private string emp_name;
        private string emp_city;

        public employee(int emp_id, string emp_name, string emp_city)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.emp_city = emp_city;
        }
        public int pemp_id
        {
            get
            {
                return this.emp_id;
            }
        }
        public string pemp_name
        {
            get
            {
                return this.emp_name;
            }
        }
        public string pemp_city
        {
            get
            {
                return this.emp_city;
            }
        }
    }
}