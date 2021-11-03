using UnityEngine;
using System;

namespace Mathematics {
    public class Rounding : MonoBehaviour {
        public RoundingType roundingType;
        [Range(2,3)] public float currentValue;

        public void Start() {
            currentValue=roundingType==RoundingType.Round ?
                         (float)Math.Round(currentValue,1)
                         : roundingType==RoundingType.Floor ?
                         Mathf.Floor(currentValue) : Mathf.Ceil(currentValue);
            Debug.Log($"Rounding: {currentValue}");
        }
    }
}