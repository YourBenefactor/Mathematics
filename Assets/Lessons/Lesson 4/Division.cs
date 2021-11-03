using UnityEngine;

namespace Mathematics {
    public class Division : MonoBehaviour {
        [Range(0,4)] public float firstValue;
        [Range(0,4)] public float secondValue;

        public void Start() {
            var divisionResult = firstValue / secondValue;
            Debug.Log($"Division: {divisionResult}");
        }
    }
}