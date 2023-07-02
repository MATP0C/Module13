using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        private static Dictionary<string, Contact> PhoneBook = new Dictionary<string, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Текущий список контактов: ");
            WriteAllContacts();

            PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));

            Console.WriteLine("Обновленный список контактов: ");
            WriteAllContacts();

            if (PhoneBook.TryGetValue("Диана", out Contact contact))
                contact.PhoneNumber = 79990000001;

            Console.WriteLine("Список после изменения: ");
            WriteAllContacts();
        }

        public static void WriteAllContacts()
        {
            foreach (var contact in PhoneBook)
                Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber + " " + contact.Value.Email);
            Console.WriteLine();
        }

        public class Contact
        {
            public Contact(long phoneNumber, string email)
            {
                PhoneNumber = phoneNumber;
                Email = email;
            }
            public long PhoneNumber { get; set; }
            public string Email { get; set; }
        }
    }
}