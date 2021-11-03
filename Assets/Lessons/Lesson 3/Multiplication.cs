using UnityEngine;

namespace Mathematics {
    public class Multiplication : MonoBehaviour {
        [Range(-4,4)] public float firstValue;
        [Range(-4,4)] public float secondValue;

        public void Start() {
            var multiplicationResult = firstValue*secondValue;
            Debug.Log($"Multiplication: {multiplicationResult}");
        }
    }
}