using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Assets._Scripts
{
    class BehaviourExtender : MonoBehaviour
    {
        public Component ApplyScript(Type classType)
        {
            return ObjectFactory.AddComponent(gameObject, classType);

        }
    }
}
