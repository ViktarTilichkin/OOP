using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOPInheritance.MyClasses
{
    public class Customer : Person
    {
        public int Id { get; set; }
        public bool MailingList { get; set; }
        public Customer(int id, string name, string address, string phone) : base(name, address, phone)
        {
            Id = id;
        }
        public Customer(int id, string name, string address, string phone, bool mailingList) : base(name, address, phone)
        {
            Id = id;
            MailingList = mailingList;
        }
        public void SetMailingList(bool mailingList)
        {
            MailingList = mailingList;
        }
        public override string ToString()
        {
            return $"Name: {Name} Home address: {Address} Phone: {Phone} , Maling List: {MailingList}";
        }

    }
}
