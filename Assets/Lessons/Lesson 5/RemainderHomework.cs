using UnityEngine;

namespace Mathematics {
    public class RemainderHomework : MonoBehaviour {
        public void Start() {
            var remainderResult = 63%4;
            Debug.Log($"Remainder Homework" +
                      $"63 % 4 = {remainderResult}");
        }
    }
}