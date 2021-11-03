using UnityEngine;
using System;

namespace Mathematics {
    public class RoundingHomework : MonoBehaviour {
        public float currentValue = 6.283f;

        public void Start() {
            Debug.Log($"Rounding Homework\r\n" +
                      $"Round (1d): {Math.Round(currentValue,1)}\r\n" +
                      $"Round (2d): {Math.Round(currentValue,2)}\r\n" +
                      $"Floor: {Mathf.Floor(currentValue)}\r\n" +
                      $"Ceil: {Mathf.Ceil(currentValue)}");
        }
    }
}