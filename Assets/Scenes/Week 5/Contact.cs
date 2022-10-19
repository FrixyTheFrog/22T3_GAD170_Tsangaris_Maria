using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MariaTsangaris
{
    public enum Hero { Undefined, BarryGee, PeterParker, BruceWayne}

    public class Contact : MonoBehaviour
    {
        [SerializeField] private Hero chosenHero = Hero.Undefined;
        [SerializeField] private string firstName;
        [SerializeField] private string lastName;
        [SerializeField] private string preferredName;
        [SerializeField] private string pronouns;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;

        public void Initialize()
        {
            // We want to set up all 3 characters
            // Using an if statement, we can say:
            // Use if statements
            // if variable == 0, set up Barry Gee
            // if variable == 1, set up Peter Parker
            // if variable == 2, set up Bruce Wayne
            // if statement or
            // switch statement

            switch (chosenHero)
            {
                case Hero.Undefined:
                    Debug.Log("Hero undefined. Set its enum in the inspector!");
                    break;
                case Hero.BarryGee:
                    Setup("Barry", "Gee", "BG", "He/Him", "0123 456 789", "Downtown Av", "thebg@gmail.com");
                    break;
                case Hero.PeterParker:
                    Setup("Peter", "Parker", "Pete", "He/Him", "0123 456 789", "20 Ingram St.", "doublepparker@hotmail.com");
                    break;
                case Hero.BruceWayne:
                    Setup("Bruce", "Wayne", "Mr. Wayne", "He/Him", "Classified", "Wayne Manor", "brucewayne@wayneenterprises.com");
                    break;
                default:
                    Debug.Log("Invalid choice!");
                    break;
            }
        }

        private void Setup(string newFirstName,
                           string newLastName,
                           string newPreferredName,
                           string newPronouns,
                           string newPhoneNumber,
                           string newAddress,
                           string newEmail)
        {
            firstName = newFirstName;
            lastName = newLastName;
            preferredName = newPreferredName;
            pronouns = newPronouns;
            phoneNumber = newPhoneNumber;
            address = newAddress;
            email = newEmail;
        }
    }
}
