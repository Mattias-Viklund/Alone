using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Scripts
{
    class Ass : MonoBehaviour
    {
        private void Start()
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<BehaviourExtender>().ApplyScript(typeof(Jetpack));

        }
    }
}
