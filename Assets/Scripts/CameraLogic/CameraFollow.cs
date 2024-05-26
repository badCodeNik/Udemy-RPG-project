using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace CameraLogic
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform following;

        private void LateUpdate()
        {
            if (following == null)
                return;
            
        }
    }
}