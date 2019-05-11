using System;
using System.Collections.Generic;

namespace Chapter11_ExceptionsAndTryCatch
{
    public class AddressBook
    {
        public Dictionary<string, Contact> contactList {get; set;} = new Dictionary<string, Contact>();

        public void AddContact (Contact contactParam){
            try{
            contactList.Add(contactParam.Email, contactParam);
        }
        catch(System.ArgumentException){
            Console.WriteLine($"{contactParam.FirstName} has already been added into the address book.");
        }}

        public Contact GetByEmail(string emailParam){
                return contactList[emailParam];
        }

    }
}