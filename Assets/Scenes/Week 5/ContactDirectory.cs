using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MariaTsangaris
{
    public class ContactDirectory : MonoBehaviour
    {
        [SerializeField] private List<Contact> contacts = new List<Contact>();

        private void Start()
        {
            // let's loop through our collection.
            // Create interger call i and give it value of 0
            // If i < Count, then do the things inside this loop
            // then, increase i by 1... making i = 1... then i = 2... then i = 3...

            for (int i = 0; i < contacts.Count; i++)
            {
                contacts[i].Initialize();
            }
        }
    }
}

