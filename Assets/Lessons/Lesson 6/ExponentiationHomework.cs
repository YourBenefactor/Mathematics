using UnityEngine;

namespace Mathematics {
    public class ExponentiationHomework : MonoBehaviour {
        public void Start() {
            var exponentiationResult = Mathf.Pow(2.0f,24.0f);
            Debug.Log($"Exponentiation Homework\r\n" +
                      $"2 ^ 24 = {exponentiationResult}");
        }
    }
}