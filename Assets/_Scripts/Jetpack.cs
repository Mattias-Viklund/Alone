using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Scripts
{
    class Jetpack : MonoBehaviour
    {
        private float fuelRemaining = 100.0f;
        private float fuelEfficiency = 25.0f; // 25 = LOW, 5 = HIGHEST
        private float fuelRefill = 10.0f; // 0.5 = LOW, 10 = HIGHEST

        private bool active = false;

        private void Start()
        {

        }

        private void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                if (fuelRemaining < 20)
                    return;
                else
                    active = true;

            }

            if (Input.GetButtonUp("Jump"))
                active = false;

            if (fuelRemaining <= 0)
                active = false;

            if (active)
            {
                fuelRemaining -= fuelEfficiency * Time.deltaTime;
                GameObject.FindGameObjectWithTag("Player").GetComponent<Player.Player>().Jump(0.5f);

            }
            else
            {
                if (fuelRemaining < 100)
                {
                    fuelRemaining += fuelRefill * Time.deltaTime;
                }
                else
                    fuelRemaining = 100;

            }
        }

        private void OnGUI()
        {
            UnityEngine.GUI.Label(new Rect(0, 45, 400, 100), "Jetpack Fuel: " + Mathf.Round(fuelRemaining));

        }
    }
}
