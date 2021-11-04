using UnityEngine;

namespace Mathematics {
    public class Remainder : MonoBehaviour {
        [Range(1,10)] public float firstValue;
        [Range(1,10)] public float secondValue;

        public void Start() {
            var remainderResult = firstValue%secondValue;
            Debug.Log($"Remainder: {remainderResult}");
        }
    }
}