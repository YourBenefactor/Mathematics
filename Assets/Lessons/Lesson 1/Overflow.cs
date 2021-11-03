using UnityEngine;

namespace Mathematics {
    public class Overflow : MonoBehaviour {
        public OverflowDirection overflowDirection;
        public int currentValue, valueOffset;

        public void Start() {
            currentValue=overflowDirection==OverflowDirection.Left ?
                         unchecked(-2147483648-valueOffset)
                         : unchecked(2147483647+valueOffset);
            Debug.Log(currentValue);
        }
    }
}