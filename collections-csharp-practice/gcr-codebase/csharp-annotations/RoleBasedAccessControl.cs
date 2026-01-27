using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections.annotations
{
   
        [AttributeUsage(AttributeTargets.Method)]
        class RoleBasedAccessControl : Attribute
        {
            public string Role { get; }

            public RoleBasedAccessControl(string role)
            {
                Role = role;
            }
        }

        class AdminPanel
        {
            [RoleBasedAccessControl("ADMIN")]
            public void DeleteUser()
            {
                Console.WriteLine("User deleted");
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter role: ");
                string role = Console.ReadLine();

                AdminPanel panel = new AdminPanel();
                var method = typeof(AdminPanel).GetMethod("DeleteUser");
                var attr = (RoleBasedAccessControl)Attribute.GetCustomAttribute(method, typeof(RoleBasedAccessControl));

                if (attr.Role == role)
                    panel.DeleteUser();
                else
                    Console.WriteLine("Access Denied!");
            }
        }
    }

