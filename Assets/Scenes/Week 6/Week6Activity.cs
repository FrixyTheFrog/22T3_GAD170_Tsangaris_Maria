using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MariaTsangarisDylanPham
{
    public class Week6Activity : MonoBehaviour
    {
        void Start()
        {
            // The cube is blue at the start of the game.
            GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }
        private void Update()
        {
            // When the position of x is less than 0, the colour is changed to red.
            if (transform.position.x < 0)
            {
                GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            }
            // WHen the position of x is greater than 0, the colour is changed to blue.
            if (transform.position.x > 0)
            {
                GetComponent<Renderer>().material.color = new Color(0, 255, 0);
            }
        }
    }
}

