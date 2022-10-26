using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MariaTsangarisDylanPham
{
    public class Week6List : MonoBehaviour
    {
        [SerializeField] private List<string> hero = new List<string>();
        void Start()
        {
            hero.Add("Batman");
            hero.Add("Superman");
            hero.Add("Green Lantern");
            hero.Add("Wonder Woman");
        }
        void Update()
        {

        }
    }
}