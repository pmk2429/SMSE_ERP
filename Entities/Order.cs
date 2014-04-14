using System;
using System.Collections.Generic;
using System.Text;

namespace Deepak_Xerox.Entities
{
    public class Order
    {
        public Order()
        {
            id = 0;
            order_no = 0;
            date = DateTime.Now;
            type_of_work = null;
            no_of_copies = 0;
            rate = 0;
            total = 0;

        }
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int order_no;

        public int OrderNo
        {
            get { return order_no; }
            set { order_no = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private string type_of_work;

        public string TOW
        {
            get { return type_of_work; }
            set { type_of_work = value; }
        }

        private int no_of_copies;

        public int NOC
        {
            get { return no_of_copies; }
            set { no_of_copies = value; }
        }

        private float rate;

        public float Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        private TypeOfWorks typeOfWork;
        public TypeOfWorks TypeOfWork
        {
            get { return typeOfWork; }
            set { typeOfWork = value; }
        }

        private int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
    }

    public enum TypeOfWorks
    {
        Xerox,
        MultiColourXerox,
        Lamination,
        SpiralBinding,
        ColorLaserPrint,
        Fax,
        ComputerJobWork
    }
}
