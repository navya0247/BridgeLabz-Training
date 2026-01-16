using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.addressBookSystem
{
    internal interface IAddressBook
    {
            void AddContact();     // UC2 + UC7
            void EditContact();    // UC3
            void DeleteContact();  // UC4
            void AddMultipleContacts(); // UC5

            void SearchByCityOrState();   // UC8
            void ViewPersonsByCityOrState();   // UC9
            void CountPersonsByCityOrState();   // UC10

            void SortContactsByName();   // UC-11

    }
}


