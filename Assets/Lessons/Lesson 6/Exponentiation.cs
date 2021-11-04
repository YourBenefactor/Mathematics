using UnityEngine;

namespace Mathematics {
    public class Exponentiation : MonoBehaviour {
        [Range(1,10)] public float firstValue;
        [Range(0,10)] public float secondValue;

        public void Start() {
            var exponentiationResult = Mathf.Pow(firstValue,secondValue);
            Debug.Log($"Exponentiation: {exponentiationResult}");
        }
    }
}