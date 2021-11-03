using UnityEngine;

namespace Mathematics {
    public class DivisionHomework : MonoBehaviour {
        public void Start() {
            var exampleResult = 9.0f-3.0f/(1.0f/3.0f)+1.0f;
            Debug.Log($"Division Homework\r\n" +
                      $"9 - 3 / 1/3 + 1 = {exampleResult}");
        }
    }
}